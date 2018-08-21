using System;
using System.Collections.Generic;

namespace DatasheetGenerator
{
    public class CellBuilder
    {
        public string MainContentCellsToString { get; set; }

        public CellBuilder(List<List<string>> allColumnsArr)
        {
            var columnKeys = new ColumnKeys().mainContentKeysArr;

            // For each Row
            for (int i = 0; i < allColumnsArr[0].Count; i++)
            {
                int currentColumn = 0;

                //Sets the key for each row
                MainContentCellsToString += columnKeys[i];

                //Foreach Row[i] append each Column[currentColumn] -- Left to Right Then Top to Bottom -- allColumnsArr[currentColumn][i]
                while (currentColumn < allColumnsArr.Count)
                {
                    MainContentCellsToString += @"<w:tc>
                    <w:tcPr>
                        <w:tcW w:w='keyWidthPH' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p>
                        <w:pPr>
                            <w:pStyle w:val='Heading2'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>" + allColumnsArr[currentColumn][i] + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
                    currentColumn++;
                }
                MainContentCellsToString += "</w:tr>";
            }
        }
    }
}