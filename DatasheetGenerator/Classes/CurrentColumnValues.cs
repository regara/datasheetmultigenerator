using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using System.Xml.XPath;

namespace DatasheetGenerator
{
    public class CurrentColumnValues
    {
        //Array stores each value
        public List<string> currentColumnValuesArr { get; set; }

        //Header fields
        public static string WALLTYPE { get; set; }

        //Main fields
        public static string PHOTO { get; set; } = "N/A";
        public static string HERS { get; set; } = "N/A";
        public static string PLANNAME { get; set; }
        public static string FILENAME { get; set; }
        public static string SQFT { get; set; }
        public static string ABVP { get; set; } = "%";
        public static string COOLP { get; set; } = "%";
        public static string STORIES { get; set; }
        public static string GLAZINGP { get; set; } = "%";
        public static string ROOFMAT { get; set; }
        public static string REFEM { get; set; }
        public static string ATTIC { get; set; }
        public static string ABVRD { get; set; }
        public static string BLWRD { get; set; }
        public static string RADIENT { get; set; }
        public static string WALL24 { get; set; }
        public static string WALL26 { get; set; }
        public static string KNEEWALL { get; set; }
        public static string OVERG { get; set; }
        public static string FLOORTYPE { get; set; }
        public static string SEEREER { get; set; }
        public static string AFUE { get; set; }
        public static string DUCTINS { get; set; }
        public static string WHF { get; set; }
        public static string FANWAT { get; set; }
        public static string AIRFLOW { get; set; }
        public static string DUCTTEST { get; set; }
        public static string CFM { get; set; }
        public static string REFCHARGE { get; set; }
        public static string SEERVERIF { get; set; }
        public static string EERVERIF { get; set; }
        public static string INFILTRATION { get; set; }
        public static string DUCTCOND { get; set; }
        public static string LOWLEAK { get; set; }
        public static string BURRIEDDUCT { get; set; }
        public static string SURFAREA { get; set; }
        public static string INSULINSPECT { get; set; }
        public static string FUELTYPE { get; set; }
        public static string UEF { get; set; }
        public static string DISTRIBUTION { get; set; }

        //Windows / Skylight
        // [ [Type], [UVal], [SHGC], [Msc User stuff Hard Coded] ] 
        public static List<List<string>> windowArray { get; set; } = new List<List<string>>{
            new List<string>{"Windows"},
            new List<string>{"U-Value"},
            new List<string>{"SHGC"},
            new List<string>{""},
            new List<string> { " ", "If all data is acceptable, please sign", "Print Name: ", "Signature: ", "Date: ", "Contractor License" }

        };

        

        public List<bool> WindowExists { get; set; } = new List<bool> {false,false,false};

        public CurrentColumnValues(XDocument doc)
        {

            /*********************** DRY PATH METHOD ***********************/

            string DryPath(IEnumerable<XElement> path, XName element)
            {
                return Convert.ToString(path.Elements(element).FirstOrDefault()?.Value);
            }

            /*********************** XMLNODE - PATHS ***********************/

            var userInput = doc.Descendants("Model").Take(1).Elements("Proj");
            var proposed = doc.Descendants("Model").Skip(1).Take(1).Elements("Proj");
            var standard = doc.Descendants("Model").Skip(2).Take(1).Elements("Proj");

            //            var wallPath = userInput.Elements("Zone").Elements("ExtWall");
            //            var wallPath = userInput.Elements("Zone").Elements("ExtWall");
            var wallNamePath = userInput.Descendants("Attic");
            var roofMatPath = doc.Descendants("Model").Take(1).Descendants("Cons");

            /*********************** Misc General Data ***********************/
            var skyLightExists = doc.XPathSelectElement("//Skylt") != null;
            string _name = DryPath(userInput, "Name");





            //            string _aboveCodePerc =  DryPath(standard.Elements("EUseSummary"), "PctSavingsCmpTDV");
            string _aboveCodePerc = Math.Round(Convert.ToDouble(standard.Elements("EUseSummary").Elements("PctSavingsCmpTDV").FirstOrDefault()?.Value),1) + "%";


            string getSpaceCoolVal() {

                XElement spaceCoolPath(string name) {
                    return standard.Elements("EnergyUse").SingleOrDefault(x => x.Element("Name").Value == name);
                }

                double temp;

                if (spaceCoolPath("EU-SpcClg")?.Value != null) {
                    temp = Math.Round(Convert.ToDouble(spaceCoolPath("EU-SpcClg")?.Elements("PctImproveTDV").SingleOrDefault().Value), 1);
                    return temp + "%";
                }
                else
                {
                    double lowestDirectionVal = 9999;

                    List<double> directionValue = new List<double>();
                    directionValue.Add(Convert.ToDouble(spaceCoolPath("N-EU-SpcClg")?.Elements("PctImproveTDV").SingleOrDefault().Value));
                    directionValue.Add(Convert.ToDouble(spaceCoolPath("S-EU-SpcClg")?.Elements("PctImproveTDV").SingleOrDefault().Value));
                    directionValue.Add(Convert.ToDouble(spaceCoolPath("E-EU-SpcClg")?.Elements("PctImproveTDV").SingleOrDefault().Value));
                    directionValue.Add(Convert.ToDouble(spaceCoolPath("W-EU-SpcClg")?.Elements("PctImproveTDV").SingleOrDefault().Value));

                    foreach (var item in directionValue)
                    {

                        Console.WriteLine("item: " + item);

                        if( lowestDirectionVal > item )
                        {
                            lowestDirectionVal = item;
                        }
                    }
                    Console.WriteLine(lowestDirectionVal);
                    lowestDirectionVal = Math.Round(lowestDirectionVal, 1);
                    Console.WriteLine(lowestDirectionVal);

                    return lowestDirectionVal + "%";
                }
            }

            /*********************** ATTIC ***********************/

            List<string> wallNames = new List<string>();
            List<string> wallMatArr = new List<string>();
            List<string> abvDeckArr = new List<string>();
            List<string> blwDeckArr = new List<string>();
            List<string> atticFloorArr = new List<string>();
            List<string> wallInsulArr = new List<string>();
            List<string> kneeWallArr = new List<string>();
            List<string> floorOvrGarArr = new List<string>();
            List<string> sidingOrStuccoArr = new List<string>();
            List<string> waterHeaterArr = new List<string>();


            string _roofMatFormated;
            string _radientBarrier = "-";
            string _abvRoofDeck = "";
            string _blwRoofDeck = "";
            string _atticFloor = "";
            string _wallInsul24 = "-";
            string _wallInsul26 = "-";
            string _kneeWall = "-";
            string _floorOvrGar = "-";
            string _floorType = "";
            string _sidingOrStucco = "";
            string _indoorAirQual = doc.Descendants("Model").Skip(1).Take(1).Elements("IAQVentRpt").SingleOrDefault()?.Element("IAQCFM")?.Value;
            string _insulConsQual = userInput.Elements("InsulConsQuality").SingleOrDefault()?.Value;
            string _airLeakage = (userInput.Elements("ACH50").SingleOrDefault()?.Value.Length == 1) ? userInput.Elements("ACH50").SingleOrDefault()?.Value + ".00%" : userInput.Elements("ACH50").SingleOrDefault()?.Value + "%";
            string _buriedDuct = "-";
            string _surfaceArea = "-";
            string _ductInConditioned = "-";
            string _waterHeater = "";
            string _Qii = doc.Descendants("Model").Skip(1).Take(1).Single()?.Element("HERSOther")?.Element("QII")?.Value;

            if (userInput.Elements("Zone").Elements("SlabFloor").Count() > 0)
                _floorType = "Slab";
            if (userInput.Elements("Zone").Elements("FloorOverCrawl").Count() > 0)
            {
                if (_floorType != "")
                    _floorType += " / ";
                _floorType += "Raised Floor";
            }



            foreach (var buriedDucts in doc.Descendants("Model").Take(1).Elements("HVACSys"))
            {

                var temp = buriedDucts.Element("DistribSystem")?.Value;
                var query = doc.Descendants("Model").Take(1)?.Elements("HVACDist").SingleOrDefault(x => x.Element("Name").Value == temp);

                if (query?.Element("AreBuried")?.Value == "1")
                {
                    _buriedDuct = "Yes";
                    break;
                }

                if (query?.Element("DuctDesign")?.Value == "1")
                {
                    _surfaceArea = "Yes";
                    break;
                }

                if (query?.Element("_ductInConditioned")?.Value == "Ducts located within the conditioned space (except < 12 lineal ft)" ||
                    query?.Element("_ductInConditioned")?.Value == "Ducts located entirely in conditioned space" ||
                    query?.Element("_ductInConditioned")?.Value == "Verified low-leakage ducts entirely in conditioned space")
                {
                    _ductInConditioned = "Yes";
                    break;
                }
            }

            foreach (var waterHeater in doc.Descendants("Model").Take(1).Elements("DHWSys"))
            {
                var temp = waterHeater.Element("DHWHeater")?.Value;
                var temp2 = doc.Descendants("Model").Take(1).Elements("DHWHeater").SingleOrDefault(x => x.Element("Name")?.Value == temp);

                if (!waterHeaterArr.Contains(temp))
                {
                    if (waterHeaterArr.Count > 0)
                        _waterHeater += " + ";

                    waterHeaterArr.Add(temp);
                    if (temp2.Element("EnergyFactor")?.Value.Split('.').ToList().ElementAt(1)?.Length == 1)
                        temp2.Element("EnergyFactor").Value += "0";
                    _waterHeater += temp2.Element("EnergyFactor")?.Value + "(" + temp2.Element("TankVolume")?.Value + ") ";
                }
            }


            foreach (var atticFloor in userInput.Elements("Zone").Elements("CeilingBelowAttic"))
            {
                if (!atticFloor.Element("Name").ToString().Contains("FAU")) {
                    var temp = atticFloor.Element("Construction");

                    if (!atticFloorArr.Contains(temp.Value.Split(' ')[0]))
                        atticFloorArr.Add(temp.Value.Split(' ')[0]);
                }
            }


            foreach (var ceil in wallNamePath)
            {
                if (!wallNames.Contains(Convert.ToString(ceil.Elements("Construction"))) &&
                   (string)ceil.Element("Construction") != "Attic Roof Garage")
                    wallNames.Add(Convert.ToString(ceil.Element("Construction")?.Value));
            }

            foreach (var roofingMat in wallNames)
            {
                var roofTypePath = roofMatPath.SingleOrDefault(x => x.Element("Name").Value == roofingMat)?.Element("RoofingLayer")?.Value;
                var radientBarrierPath = roofMatPath.SingleOrDefault(x => x.Element("Name").Value == roofingMat)?.Element("RadiantBarrier")?.Value;
                var aboveRoofDeckPath = roofMatPath.SingleOrDefault(x => x.Element("Name").Value == roofingMat)?.Element("AbvDeckInsulLayer")?.Value;
                var belowRoofDeckPath = roofMatPath.SingleOrDefault(x => x.Element("Name").Value == roofingMat)?.Element("CavityLayer")?.Value;


                switch (roofTypePath)
                {
                    case "Light Roof (Asphalt Shingle)":
                        wallMatArr.Add("Asphalt");
                        break;
                    case "5 PSF (Normal Gravel)":
                        wallMatArr.Add("Built Up");
                        break;
                    case "10 PSF (RoofTile)":
                        wallMatArr.Add("Tile");
                        break;
                    case "15 PSF (Heavy Ballast or Pavers)":
                        wallMatArr.Add("Heavy Ballast");
                        break;
                    case "25 PSF (Very Heavy Ballast or Pavers)":
                        wallMatArr.Add("Very Heavy Ballast");
                        break;
                    case "Light Roof (Metal Tile)":
                        wallMatArr.Add("Metal");
                        break;
                    default:
                        wallMatArr.Add("??????");
                        break;

                }

                if (radientBarrierPath == "1")
                    _radientBarrier = "Yes";

                if (!abvDeckArr.Contains(aboveRoofDeckPath) && aboveRoofDeckPath != "- no insulation -")
                    abvDeckArr.Add(aboveRoofDeckPath);



                if (!blwDeckArr.Contains(belowRoofDeckPath) && belowRoofDeckPath != "- no insulation -")
                    blwDeckArr.Add(belowRoofDeckPath.Replace(" ", "-"));
            }

            foreach (var zone in userInput.Elements("Zone"))
            {
                foreach (var wall in zone.Elements("ExtWall"))
                {
                    if (!wallInsulArr.Contains(wall.Element("Construction").Value))
                    {
                        wallInsulArr.Add(wall.Element("Construction").Value);

                        void WallFormater(string wallPathVal)
                        {

                           

                            string firstWordInString = wallPathVal.Split(' ')[0];
                            string rVal = Regex.Split(firstWordInString, @"\D+")[1];
                            string wallValue = "";

                            if (wallPathVal.Contains("w/1 Foam Wall")) {
                                wallValue = firstWordInString + "+ R-4";
                            } else {
                                wallValue = firstWordInString; ;
                            }


                            if (firstWordInString == "existing" || firstWordInString == "Wall")
                            {
                                //ignore?
                            }
                            else if (Convert.ToInt32(rVal) <= 15)
                            {

                                if (_wallInsul24.Length == 1)
                                    _wallInsul24 = "";

                                if (!_wallInsul24.Contains(wallValue))
                                {
                                    if (_wallInsul24.Length > 1)
                                        _wallInsul24 += " / ";

                                    _wallInsul24 += wallValue;
                                    if (wall.Element("Construction").Value.Split(' ').Last().Contains("R"))
                                        _wallInsul24 += " + " + wall.Element("Construction").Value.Split(' ').Last().Split('-')[1];
                                }
                            }
                            else
                            {
                                if (_wallInsul26.Length == 1)
                                    _wallInsul26 = "";

                                if (!_wallInsul26.Contains(wallValue))
                                {
                                    if (_wallInsul26.Length > 1)
                                        _wallInsul26 += " / ";

                                    _wallInsul26 += wallValue;
                                    if (wall.Element("Construction").Value.Split(' ').Last().Contains("R"))
                                        _wallInsul26 += " + " + wall.Element("Construction").Value.Split(' ').Last().Split('-')[1];
                                }
                            }
                        }
                        WallFormater(wall.Element("Construction").Value);
                    }

                    foreach (var wallI in zone.Elements("IntWall"))
                    {
                        if (!kneeWallArr.Contains(wallI.Element("Construction").Value.Split(' ')[0]) && wallI.Element("Outside").Value != "Garage")
                            kneeWallArr.Add(wallI.Element("Construction").Value.Split(' ')[0]);
                    }

                    foreach (var floor in zone.Elements("InteriorFloor"))
                    {
                        if (!floorOvrGarArr.Contains(floor.Element("Construction").Value.Split(' ')[0]))
                            floorOvrGarArr.Add(floor.Element("Construction").Value.Split(' ')[0]);
                    }
                }
            }

            foreach (var wallt in wallInsulArr)
            {
                var tempPath = roofMatPath.SingleOrDefault(x => x.Element("Name")?.Value == wallt)
                    .Element("WallExtFinishLayer").Value;
                if (!sidingOrStuccoArr.Contains(tempPath))
                {
                    sidingOrStuccoArr.Add(tempPath);


                    switch (tempPath)
                    {
                        case "Synthetic Stucco":
                            _sidingOrStucco += "1-Coat Stucco";
                            break;
                        case "3 Coat Stucco":
                            _sidingOrStucco += "3-Coat Stucco";
                            break;
                        case "Wood Siding/sheathing/decking":
                            _sidingOrStucco += "Siding/Sheathing";
                            break;
                        default:
                            _sidingOrStucco += "Unknown Type";
                            break;
                    }
                }
            }

            string joinedBySlash(List<string> array) {
                var tempArr = new List<string>();

                array.ForEach(e =>
                {
                    if (!tempArr.Contains(e)) tempArr.Add(e);
                });
                
                return String.Join(" / ", tempArr);
            }

            if (abvDeckArr.Count == 0)
                _abvRoofDeck = "-";
            else
                _abvRoofDeck = String.Join(" / ", abvDeckArr);

            if (blwDeckArr.Count == 0)
                _blwRoofDeck = "-";
            else
                _blwRoofDeck = joinedBySlash(blwDeckArr);

            _roofMatFormated = joinedBySlash(wallMatArr);
            _atticFloor = joinedBySlash(atticFloorArr);
            _kneeWall = joinedBySlash(kneeWallArr);
            _floorOvrGar = joinedBySlash(floorOvrGarArr);

            _wallInsul24 = string.Join(" / ", _wallInsul24.Split('/').Distinct().OrderBy(x => x));
            _wallInsul26 = string.Join(" / ", _wallInsul26.Split('/').Distinct().OrderBy(x => x));
            _kneeWall = string.Join(" / ", _kneeWall.Split('/').Distinct().OrderBy(x => x));



            /*********************** WINDOWS ***********************/
            foreach (var zones in proposed.Elements("Zone"))
            {
                foreach (var walls in zones.Elements("ExtWall"))
                {

                    foreach (var windows in walls.Elements("Win"))
                    {
                        //resets checking
                        for (var i = 0; i < WindowExists.Count; i++) WindowExists[i] = false;

                        //If a value is null
                        if (windows?.Element("WinType")?.Value == null || windows?.Element("NFRCUfactor")?.Value == null || windows?.Element("NFRCSHGC")?.Value == null)
                        {
                            if (!windowArray[0].Contains("Unknown Window"))
                            {
                                Console.WriteLine("Unknown Window Found");
                                windowArray[0].Add((windows?.Element("WinType")?.Value != null) ? windows?.Element("WinType")?.Value : "Unknown Window");
                                windowArray[1].Add((windows?.Element("NFRCUfactor")?.Value != null) ? windows?.Element("NFRCUfactor")?.Value : "Unknown Value");
                                windowArray[2].Add((windows?.Element("NFRCSHGC")?.Value != null) ? windows?.Element("NFRCSHGC")?.Value : "Unknown Value");
                            }
                        }
                        else {
                            windowArray[0].ForEach(e => { if (e.Contains(windows.Element("WinType")?.Value)) WindowExists[0] = true; });
                            windowArray[1].ForEach(e => { if (e.Contains(windows.Element("NFRCUfactor")?.Value)) WindowExists[1] = true; });
                            windowArray[2].ForEach(e => { if (e.Contains(windows.Element("NFRCSHGC")?.Value)) WindowExists[2] = true; });

                            if (!WindowExists[0] && !WindowExists[1] && !WindowExists[2])
                            {
                                Console.WriteLine("Unique Window To Array");
                                windowArray[0].Add(windows.Element("WinType")?.Value);
                                windowArray[1].Add(windows.Element("NFRCUfactor")?.Value);
                                windowArray[2].Add(windows.Element("NFRCSHGC")?.Value);
                            }
                        }                   

                    }
                }
            }

            //Update this to somethign like above (windows)
            if (skyLightExists)
            {
                windowArray[0].Add("Skylight");
                windowArray[1].Add(userInput.Descendants("Skylt").FirstOrDefault().Element("NFRCUfactor").Value);
                windowArray[2].Add(userInput.Descendants("Skylt").FirstOrDefault().Element("NFRCSHGC").Value);
            }

            /*********************** PLACEHOLDER ***********************/

            string _wholeHouseFan = "";

            foreach (var whf in proposed.Elements("UnitClVentCFM"))
            {
                if (_wholeHouseFan.Length != 0 && whf.Value != "0")
                    _wholeHouseFan += " + ";
                if (whf.Value != "0")
                    _wholeHouseFan += whf.Value;
            }

            _wholeHouseFan = string.Join("+", _wholeHouseFan.Split('+').Distinct().OrderByDescending(x => x));

            _wholeHouseFan = "Yes ( " + _wholeHouseFan + ")";
            if (_wholeHouseFan == "Yes ( )")
                _wholeHouseFan = "-";

            var property = (from p in doc.Descendants("Model").Where(n => (string)n.Attribute("Name") == "Proposed")
                            let proj = p.Element("Proj")
                            select new
                            {
                                photovoltaic = proj.Element("PVMinRatedPwrRpt").Value,
                                planStucco = proj.Element("Name").Value,
                                fileName = proj.Element("ModelFile").Value,
                                squareFeet = proj.Element("CondFloorArea").Value,
                                stories = proj.Element("NumStories").Value,
                                glazing = Math.Round(Convert.ToDouble(proj.Element("CondWinAreaCFARat").Value), 3),
                                reflectEmiss = proj.Elements("Attic")?.FirstOrDefault()?.Element("RoofSolReflect").Value + " / " + proj.Elements("Attic")?.FirstOrDefault()?.Element("RoofEmiss").Value,
                                seerEer = (proj.Element("SCSysRpt")?.Element("MinCoolSEER")?.Value != null) ? proj.Element("SCSysRpt")?.Element("MinCoolSEER")?.Value + " / " + proj.Element("SCSysRpt")?.Element("MinCoolEER")?.Value : "-",
                                afue = proj.Element("SCSysRpt")?.Element("MinHeatEffic")?.Value,
                                ductInsul = proj.Element("SCSysRpt")?.Element("MinDistribInsRval")?.Value,
                                fanWattage = proj.Element("SCSysRpt")?.Element("HERSFanEff")?.Value,
                                airflow = proj.Element("SCSysRpt")?.Element("HERSAHUAirFlow")?.Value,
                                airflowVal = proj.Element("SCSysRpt")?.Element("MinCoolCFMperTon")?.Value,
                                ductTestingReq = proj.Element("SCSysRpt")?.Element("HERSDuctLeakage")?.Value,
                                ductTestingVal = proj.Element("SCSysRpt")?.Element("HERSDuctLkgRptMsg")?.Value,
                                refCharg = proj.Element("SCSysRpt")?.Element("HERSACCharg")?.Value,
                                seerVerif = proj.Element("SCSysRpt")?.Element("HERSSEER")?.Value,
                                eerVerif = proj.Element("SCSysRpt")?.Element("HERSEER")?.Value,
                                lowLeakageAir = proj.Element("SCSysRpt")?.Element("LLAHUStatus")?.Value,
                                fuelType = proj.Element("GasType")?.Value,
                                distribution = "Standard"
                            }).SingleOrDefault();

            List<string> result = Convert.ToString(property).Split(',').ToList();


            WALLTYPE = _sidingOrStucco;
            PHOTO = (property.photovoltaic == "0") ? "N/A" : (property.photovoltaic.Length == 1) ? property.photovoltaic + ".00 kWdc" : property.photovoltaic + " kWdc";
            HERS = "N/A";
            PLANNAME = _name;
            FILENAME = property.fileName;
            SQFT = property.squareFeet;
            ABVP = _aboveCodePerc;
            COOLP = getSpaceCoolVal();
            STORIES = property.stories;
            GLAZINGP = (property.glazing == 0) ? "0.00%" : property.glazing.ToString().Split('.')?[1]?.Insert(2, ".") + "%";
            ROOFMAT = _roofMatFormated;
            REFEM = property.reflectEmiss;
            ATTIC = _atticFloor;
            ABVRD = _abvRoofDeck;
            BLWRD = _blwRoofDeck;
            RADIENT = _radientBarrier;
            WALL24 = _wallInsul24;
            WALL26 = _wallInsul26;
            KNEEWALL = _kneeWall;
            OVERG = (_floorOvrGar != "") ? _floorOvrGar : "-";
            FLOORTYPE = _floorType;
            SEEREER = property.seerEer;
            AFUE = (property.afue != null ) ? property.afue : "-";
            DUCTINS = (property.ductInsul != null ) ? "R-" + property.ductInsul : "-";
            WHF = _wholeHouseFan;
            FANWAT = (property.fanWattage == "1") ? "Yes" : "-";
            AIRFLOW = (property.airflow == "1") ? "Yes (" + property.airflowVal + ")" : "-";
            DUCTTEST = (property.ductTestingReq == "1") ? "Yes (" + property.ductTestingVal + "%)" : "-";
            CFM = (_indoorAirQual != "0") ? "Yes (" + _indoorAirQual + ")" : "-";
            REFCHARGE = (property.refCharg == "1") ? "Yes" : "-";
            SEERVERIF = (property.seerVerif == "1") ? "Yes" : "-";
            EERVERIF = (property.eerVerif == "1") ? "Yes" : "-";
            INFILTRATION = (Convert.ToInt32(_airLeakage.Split('.')[0]) >= 5) ? "-" : "Yes (" + proposed.Elements("CFM50").SingleOrDefault()?.Value + ")";
            DUCTCOND = _ductInConditioned;
            LOWLEAK = (property.lowLeakageAir == "Has Low Leakage Air Handler") ? "Yes" : "-";
            BURRIEDDUCT = _buriedDuct;
            SURFAREA = _surfaceArea;
            INSULINSPECT = (_Qii == "1") ? "Yes" : "-";
            FUELTYPE = property.fuelType;
            UEF = _waterHeater;
            DISTRIBUTION = property.distribution;

            currentColumnValuesArr = new List<string> {
                PHOTO, HERS, PLANNAME, FILENAME, SQFT, ABVP, COOLP, STORIES, GLAZINGP, ROOFMAT, REFEM, ATTIC, ABVRD, BLWRD,
                RADIENT, WALL24, WALL26, KNEEWALL, OVERG, FLOORTYPE, SEEREER, AFUE,
                DUCTINS, WHF, FANWAT, AIRFLOW, DUCTTEST, CFM, REFCHARGE, SEERVERIF, EERVERIF, INFILTRATION, DUCTCOND,
                LOWLEAK, BURRIEDDUCT, SURFAREA, INSULINSPECT, FUELTYPE, UEF, DISTRIBUTION
            };
        }
        
    }
}