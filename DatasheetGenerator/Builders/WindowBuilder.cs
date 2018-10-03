using System;
using System.Collections.Generic;

namespace DatasheetGenerator
{
    [System.Runtime.InteropServices.Guid("39CC3CDE-310D-44CF-8913-11E6F1B40C85")]
    public class WindowBuilder
    {
        public string Windows { get; set; }
        public string[] WindowCellWidthArr { get; } = { "2268", "1116", "1116", "1170", "5238" };
        public List<string> windowBuilderTemp { get; set; } = new List<string> { "<w:tr>", "<w:tr>", "<w:tr>", "<w:tr>", "<w:tr>" };


        public string windowBuild { get; set; } = @"<w:p>
                     <w:pPr>
                         <w:rPr>
                             <w:vanish/>
                         </w:rPr>
                     </w:pPr>
                 </w:p>
                 <w:tbl>
                     <w:tblPr>
                         <w:tblpPr w:leftFromText='180' w:rightFromText='180' w:vertAnchor='text' w:horzAnchor='page' w:tblpX='793' w:tblpY='103'/>
                         <w:tblOverlap w:val='never'/>
                         <w:tblW w:w='10908' w:type='dxa'/>
                         <w:tblLook w:val='0000' w:firstRow='0' w:lastRow='0' w:firstColumn='0' w:lastColumn='0' w:noHBand='0' w:noVBand='0'/>
                     </w:tblPr>
                     <w:tblGrid>
                         <w:gridCol w:w='2268'/>
                         <w:gridCol w:w='1116'/>
                         <w:gridCol w:w='1116'/>
                         <w:gridCol w:w='1170'/>
                         <w:gridCol w:w='5238'/>
                     </w:tblGrid>";
        



        string windowCellBuilder(string value, bool border, bool centered, bool highlighted, string cellWidth, bool Bold, bool Underlined, bool rightAligned)
        {

            var builder = "<w:tc>";

            if(border)
                builder += @"
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>";
            else
                builder += @"<w:tcPr>
                        <w:tcW w:w='" + cellWidth + @"' w:type='dxa'/>
                </w:tcPr>";

            builder += @"<w:p>
                   <w:pPr>";
            if (Bold) builder += "<w:pStyle w:val='Heading7'/>";
            if (centered) builder += "<w:jc w:val='center'/>";
            if (rightAligned) builder += "<w:jc w:val='right'/>";

            builder += @"<w:rPr>
                            <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                           <w:sz w:val='20'/>
                       </w:rPr>
                   </w:pPr>
                   <w:r>
                       <w:rPr>
                           <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                           <w:sz w:val='20'/>";

            if (Underlined) builder += "<w:u w:val='single'/>";

            if (highlighted) builder += "<w:highlight w:val='lightGray'/>";

            builder +=@"</w:rPr>
                       <w:t>" + value + @"</w:t>
                   </w:r>
               </w:p>
            </w:tc>";

            return builder;
        }

        public WindowBuilder(List<List<string>> windowArrays)
        {

            int largestArrCount = 0;
            for (int i = 0; i < 2; i++)
            {
                //Sets the largestArrCount
                windowArrays.ForEach(e =>
                {

                    for (var t = 0; t < e.Count; t++)
                    {
                        try
                        {
                            if (e[t] == "")
                            {
                                while (e[t] == "")
                                {
                                    e.RemoveAt(t);
                                }
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Window Array: Something went wrong?? (nonbreaking)");
                            //Temp Patch
                        }
                       
                    }

                    if (i == 0)
                    {
                        if (e.Count > largestArrCount)
                        {
                            largestArrCount = e.Count;
                        }
                    }
                    else
                    {
                        if (e.Count > 7)
                        {
                            while (windowArrays[4].Count < largestArrCount)
                            {
                                windowArrays[4].Insert(0, " ");
                            }
                        }
                        else
                        {
                            while (e.Count < largestArrCount)
                            {
                                e.Insert((e.Count), "");
                            }
                        }
                    }                    
                });
            }

            //Itterate for Column height; foreach row only get 1 index [i] merge them together.

            for (var i = 0; i < largestArrCount; i++)
            {
                windowBuild += "<w:tr>";

                for (var a = 0; a <= 4; a++)
                {
                    windowBuild += windowCellBuilder(
                        windowArrays[a][i],
                        (a == 4),
                        (a == 1 || a == 2),
                        false,
                        WindowCellWidthArr[a],
                        (a == 1 && i == 0) || (a == 2 && i == 0),
                        (a == 1 && i == 0) || (a == 2 && i == 0),
                        (a == 0 && i != 0)
                    );

                }
                windowBuild += "</w:tr>";
                Console.WriteLine("/TR ended");




                if (i == largestArrCount -1)
                {
                    windowBuild += "<w:tr>";

                    windowBuild += windowCellBuilder(
                        "Date of Plans:",
                        false,
                        false,
                        false,
                        i.ToString(),
                        false,
                        false,
                        false
                    );

                    windowBuild += windowCellBuilder(
                        "date",
                        false,
                        false,
                        true,
                        i.ToString(),
                        false,
                        false,
                        false
                    ).Replace("<w:sz w:val='20'/>", "<w:sz w:val='22'/>");

                    windowBuild += windowCellBuilder(
                        "",
                        false,
                        false,
                        false,
                        i.ToString(),
                        false,
                        false,
                        false
                    );

                    windowBuild += windowCellBuilder(
                        "",
                        false,
                        false,
                        false,
                        i.ToString(),
                        false,
                        false,
                        false
                    );

                    windowBuild += @"<w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t xml:space='preserve'>PO Required? </w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Check1'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:checkBox>
                                        <w:sizeAuto/>
                                        <w:default w:val='0'/>
                                    </w:checkBox>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='7' w:name='Check1'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMCHECKBOX </w:instrText>
                        </w:r>
                        <w:r w:rsidR='00430A6D'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:r>
                        <w:r w:rsidR='00430A6D'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='7'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t xml:space='preserve'> No </w:t>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Check2'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:checkBox>
                                        <w:sizeAuto/>
                                        <w:default w:val='0'/>
                                    </w:checkBox>
                                </w:ffData>
                            </w:fldChar>
                        </w:r>
                        <w:bookmarkStart w:id='8' w:name='Check2'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMCHECKBOX </w:instrText>
                        </w:r>
                        <w:r w:rsidR='00430A6D'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:r>
                        <w:r w:rsidR='00430A6D'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='separate'/>
                        </w:r>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='end'/>
                        </w:r>
                        <w:bookmarkEnd w:id='8'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t xml:space='preserve'> Yes # </w:t>
                        </w:r>
                    </w:p>
                </w:tc>";


                    windowBuild += "</w:tr>";

                }

            }
            Console.WriteLine("WindowBuilder iterations finished");

        }
    }
}