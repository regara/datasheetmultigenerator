using System;
using System.Collections.Generic;
using System.Linq;

namespace DatasheetGenerator
{
    public class CellBuilder
    {
        public string MainContentCellsToString { get; set; }

        public CellBuilder(List<List<string>> allColumnsArr)
        {
            if (allColumnsArr.Count == 0) return;

            var columnKeys = new ColumnKeys().mainContentKeysArr;


            // For each Row
            for (int i = 0; i < allColumnsArr[0].Count; i++)
            {
                int currentColumn = 0;

                //Sets the key for each row
                MainContentCellsToString += columnKeys[i];
                
                //Foreach Row[i] append each Column[currentColumn] -- Left to Right Then Top to Bottom -- AllColumnsArr[currentColumn][i]
                while (currentColumn < allColumnsArr.Count)
                {
                    if(new[] { 2,8,19,23,27,36,39}.Contains(i))
                    {
                        MainContentCellsToString += @"<w:tc>
                    <w:tcPr>
                        <w:tcW w:w='columnWidth' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='ColumnFontWeight'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='ColumnFontWeight'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>" + allColumnsArr[currentColumn][i] + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
                    }
                    else
                    {
                        MainContentCellsToString += @"<w:tc>
                    <w:tcPr>
                        <w:tcW w:w='columnWidth' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='ColumnFontWeight'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='ColumnFontWeight'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>" + allColumnsArr[currentColumn][i] + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
                    }

                    
                    currentColumn++;
                }
                MainContentCellsToString += "</w:tr>";
            }
        }
    }
}