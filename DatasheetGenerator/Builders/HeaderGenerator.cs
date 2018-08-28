using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace DatasheetGenerator
{
    public class HeaderGenerator
    {
        //Header fields
        public static string TODAYDATE { get; set; }
        public static string SOFTVERSION { get; set; }
        public static string PROJECTNAME { get; set; }
        public static string CITY { get; set; }
        public static string CLIMATEZONE { get; set; }


        public string HeaderToString { get; set; }



        public HeaderGenerator(XDocument doc)
        {

            /*********************** DRY PATH METHOD ***********************/

            string DryPath(IEnumerable<XElement> path, XName element)
            {
                return Convert.ToString(path.Elements(element).FirstOrDefault()?.Value);
            }

            //Path
            var userInput = doc.Descendants("Model").Take(1).Elements("Proj");

            //gets header values
            string[] _softversionTemp = Convert.ToString(userInput.Elements("SoftwareVersion").First().Value).Split(' ')[1].Split('.');
            string _softversion = "CBECC V" + _softversionTemp[1] + "." + _softversionTemp[2];

            string _name = DryPath(userInput, "Name");
            string _city = DryPath(userInput, "City");
            if (_city.Split(' ').Last() != "CA" && !_city.Split(' ').Last().Contains(",CA"))
            {
                _city += ", CA";
            }

            string _climateZone = DryPath(userInput, "ClimateZone").Split(' ')[0].Split('Z')[1];

            TODAYDATE = DateTime.Now.ToString("MM/dd/yyyy");
            SOFTVERSION = _softversion;
            PROJECTNAME = _name + " ";
            CITY = " " + _city;
            CLIMATEZONE = _climateZone;

            HeaderToString = @"<w:tblPr>
                <w:tblW w:w='10800' w:type='dxa'/>
                <w:tblInd w:w='-972' w:type='dxa'/>
                <w:tblLayout w:type='fixed'/>
                <w:tblLook w:val='0000' w:firstRow='0' w:lastRow='0' w:firstColumn='0' w:lastColumn='0' w:noHBand='0' w:noVBand='0'/>
            </w:tblPr>
            <w:tblGrid>
                <w:gridCol w:w='2391'/>
                <w:gridCol w:w='2917'/>
                <w:gridCol w:w='236'/>
                <w:gridCol w:w='2016'/>
                <w:gridCol w:w='3240'/>
            </w:tblGrid>
            <w:tr w:rsidR='00D23B71'>
                <w:trPr>
                    <w:cantSplit/>
                    <w:trHeight w:val='47'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2391' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00B307B8'>
                        <w:pPr>
                            <w:rPr>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:bookmarkStart w:id='0' w:name='_GoBack'/>
                        <w:bookmarkEnd w:id='0'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>" + TODAYDATE + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2917' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:jc w:val='right'/>
                            <w:rPr>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t xml:space='preserve'>Job# </w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text2'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='no.'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='1' w:name='Text2'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>no.</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='1'/>
<w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>&#160; &#160;</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text3'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='initials'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='2' w:name='Text3'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>initials</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='2'/>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5492' w:type='dxa'/>
                        <w:gridSpan w:val='3'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='000000'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:spacing w:line='260' w:lineRule='exact'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:b/>
                                <w:spacing w:val='10'/>
                                <w:sz w:val='16'/>
                                <w:highlight w:val='black'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:b/>
                                <w:spacing w:val='10'/>
                                <w:sz w:val='16'/>
                            </w:rPr>
                            <w:t>CONSERVATION FOR THE CALIFORNIA LIFESTYLE</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='00D23B71'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:rPr>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge w:val='restart'/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge w:val='restart'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00DC1C90'>
                        <w:pPr>
                            <w:tabs>
                                <w:tab w:val='left' w:pos='3151'/>
                            </w:tabs>
                        </w:pPr>
                        <w:r>
                            <w:pict>
                                <v:shapetype id='_x0000_t75' coordsize='21600,21600' o:spt='75' o:preferrelative='t' path='m@4@5l@4@11@9@11@9@5xe' filled='f' stroked='f'>
                                    <v:stroke joinstyle='miter'/>
                                    <v:formulas>
                                        <v:f eqn='if lineDrawn pixelLineWidth 0'/>
                                        <v:f eqn='sum @0 1 0'/>
                                        <v:f eqn='sum 0 0 @1'/>
                                        <v:f eqn='prod @2 1 2'/>
                                        <v:f eqn='prod @3 21600 pixelWidth'/>
                                        <v:f eqn='prod @3 21600 pixelHeight'/>
                                        <v:f eqn='sum @0 0 1'/>
                                        <v:f eqn='prod @6 1 2'/>
                                        <v:f eqn='prod @7 21600 pixelWidth'/>
                                        <v:f eqn='sum @8 21600 0'/>
                                        <v:f eqn='prod @7 21600 pixelHeight'/>
                                        <v:f eqn='sum @10 21600 0'/>
                                    </v:formulas>
                                    <v:path o:extrusionok='f' gradientshapeok='t' o:connecttype='rect'/>
                                    <o:lock v:ext='edit' aspectratio='t'/>
                                </v:shapetype>
                                <v:shape id='_x0000_i1025' type='#_x0000_t75' style='width:89.25pt;height:90pt'>
                                    <v:imagedata r:id='rId7' o:title='datasheet header'/>
                                </v:shape>
                            </w:pict>
                        </w:r>
                        <w:r w:rsidR='00D23B71'>
                            <w:tab/>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge w:val='restart'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='NoSpacing'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='72'/>
                                <w:szCs w:val='72'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='72'/>
                                <w:szCs w:val='72'/>
                            </w:rPr>
                            <w:t>CL</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='48'/>
                                <w:szCs w:val='48'/>
                            </w:rPr>
                            <w:t>&amp;</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='72'/>
                                <w:szCs w:val='72'/>
                            </w:rPr>
                            <w:t>E</w:t>
                        </w:r>
                    </w:p>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='NoSpacing'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='14'/>
                                <w:szCs w:val='14'/>
                                <w:u w:val='single'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='14'/>
                                <w:szCs w:val='14'/>
                                <w:u w:val='single'/>
                            </w:rPr>
                            <w:t>A Division of William Lilly &amp; Associates</w:t>
                        </w:r>
                    </w:p>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='NoSpacing'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='11'/>
                                <w:szCs w:val='11'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='11'/>
                                <w:szCs w:val='11'/>
                            </w:rPr>
                            <w:t>Title 24 Compliance-Residential/Non-Residential</w:t>
                        </w:r>
                    </w:p>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='NoSpacing'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='12'/>
                                <w:szCs w:val='12'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='12'/>
                                <w:szCs w:val='12'/>
                            </w:rPr>
                            <w:t>3015 Dale Court</w:t>
                        </w:r>
                    </w:p>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='NoSpacing'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='12'/>
                                <w:szCs w:val='12'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='12'/>
                                <w:szCs w:val='12'/>
                            </w:rPr>
                            <w:t>Ceres, CA 95307</w:t>
                        </w:r>
                    </w:p>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='NoSpacing'/>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:sz w:val='12'/>
                                <w:szCs w:val='12'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Swis721 Ex BT' w:hAnsi='Swis721 Ex BT'/>
                                <w:sz w:val='12'/>
                                <w:szCs w:val='12'/>
                            </w:rPr>
                            <w:t>Ph: 209-538-2879 Fx: 209-538-2885</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='00D23B71'>
                <w:trPr>
                    <w:cantSplit/>
                    <w:trHeight w:val='179'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='006D6F73'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text4'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='contact name'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='3' w:name='Text4'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>contact name</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='3'/>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006D6F73'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73' w:rsidP='00590613'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text4'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='customer'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>customer</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge/>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006D6F73'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73' w:rsidP='00590613'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text5'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='street'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='4' w:name='Text5'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>street</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='4'/>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge/>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006D6F73'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73' w:rsidP='00590613'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text7'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='city, state, zip'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='5' w:name='Text7'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>city, state, zip</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='5'/>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge/>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006D6F73'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73' w:rsidP='006D6F73'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text8'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='phone number'/>
                                    </w:textInput>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='6' w:name='Text8'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMTEXT </w:instrText>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>phone number</w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='6'/>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge/>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006D6F73' w:rsidRDefault='006D6F73'/>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='00D23B71'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRPr='00914550' w:rsidRDefault='00FE10F0' w:rsidP='00943EB5'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>" + SOFTVERSION + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='236' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2016' w:type='dxa'/>
                        <w:vMerge/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3240' w:type='dxa'/>
                        <w:vMerge/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'/>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='00D23B71'>
                <w:trPr>
                    <w:cantSplit/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5308' w:type='dxa'/>
                        <w:gridSpan w:val='2'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71' w:rsidP='000F6CC0'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t xml:space='preserve'>Re: </w:t>
                        </w:r>
                        <w:r w:rsidR='00FE10F0'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t xml:space='preserve'>" + PROJECTNAME + @" </w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t>in</w:t>
                        </w:r>
                        <w:r w:rsidR='00FE10F0'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:t xml:space='preserve'> " + CITY + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5492' w:type='dxa'/>
                        <w:gridSpan w:val='3'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71' w:rsidP='00BC56A9'>
                       
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:b/>
                                <w:bCs/>
                            </w:rPr>
                            <w:t xml:space='preserve'>&#160; Climate Zone </w:t>
                        </w:r>
                        <w:r w:rsidR='00BC56A9'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:b/>
                                <w:bCs/>
                            </w:rPr>
                            <w:t>" + CLIMATEZONE + @"</w:t>
                        </w:r>
                        <w:r w:rsidR='00BC56A9'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:b/>
                                <w:bCs/>
                            </w:rPr>
                            <w:t> &#160; &#160; &#160; 2016 Code Compliance</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
        </w:tbl>
        <w:p w:rsidR='00D23B71' w:rsidRPr='00563E5C' w:rsidRDefault='00D23B71'>
            <w:pPr>
                <w:spacing w:before='120'/>
                <w:ind w:left='-1080' w:right='-1080'/>
                <w:jc w:val='center'/>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:color w:val='FFFFFF'/>
                    <w:sz w:val='22'/>
                    <w:szCs w:val='22'/>
                </w:rPr>
            </w:pPr>
        </w:p>";

        }
    }
}