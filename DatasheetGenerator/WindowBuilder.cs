namespace DatasheetGenerator
{
    public class WindowBuilder
    {
        public string Windows { get; set; }

        public WindowBuilder()
        {
            //Temp - need to automate / hook up - currently a placeholder
            Windows = @"<w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
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
            </w:tblGrid>
            <w:tr w:rsidR='00D23B71'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:bCs/>
                                <w:szCs w:val='24'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:bCs/>
                                <w:szCs w:val='24'/>
                            </w:rPr>
                            <w:t>Windows</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='Heading7'/>
                            <w:rPr>
                                <w:u w:val='single'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:u w:val='single'/>
                            </w:rPr>
                            <w:t>U-Value</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='Heading7'/>
                            <w:rPr>
                                <w:u w:val='single'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:u w:val='single'/>
                            </w:rPr>
                            <w:t>SHGC</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='Heading7'/>
                            <w:rPr>
                                <w:u w:val='single'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='Heading7'/>
                            <w:jc w:val='left'/>
                            <w:rPr>
                                <w:b w:val='0'/>
                                <w:bCs w:val='0'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006A3390'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='right'/>
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
                            <w:t xml:space='preserve'>" + CurrentColumnValues.WIN1 + @" </w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.UVAL1 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.SHGC1 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:pStyle w:val='Heading7'/>
                            <w:jc w:val='left'/>
                            <w:rPr>
                                <w:b w:val='0'/>
                                <w:bCs w:val='0'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:b w:val='0'/>
                                <w:bCs w:val='0'/>
                            </w:rPr>
                            <w:t>If all data is acceptable, please sign</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006A3390'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='right'/>
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
                            <w:t>" + CurrentColumnValues.WIN2 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.UVAL2 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.SHGC2 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
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
                            <w:t>Print Name:</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006A3390'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='right'/>
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
                            <w:t xml:space='preserve'>" + CurrentColumnValues.WIN3 + @" </w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.UVAL3 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.SHGC3 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
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
                            <w:t>Signature:</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006A3390'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='right'/>
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
                            <w:t>" + CurrentColumnValues.WIN4 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.UVAL4 + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.SHGC4 + @"</w:t>
                        </w:r>
                        <w:bookmarkStart w:id='0' w:name='_GoBack'/>
                        <w:bookmarkEnd w:id='0'/>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
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
                            <w:t xml:space='preserve'>Date: </w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='006A3390'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='right'/>
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
                            <w:t>" + CurrentColumnValues.SKYLT + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.UVAL + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
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
                            <w:t>" + CurrentColumnValues.SHGC + @"</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='5238' w:type='dxa'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:left w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='006A3390' w:rsidRDefault='006A3390' w:rsidP='006A3390'>
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
                            <w:t>Contractor License</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>
            <w:tr w:rsidR='00D23B71'>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='2268' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:szCs w:val='24'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:szCs w:val='24'/>
                            </w:rPr>
                            <w:t>Date of Plans:</w:t>
                        </w:r>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00B307B8'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:szCs w:val='24'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='22'/>
                            </w:rPr>
                            <w:fldChar w:fldCharType='begin'>
                                <w:ffData>
                                    <w:name w:val='Text1'/>
                                    <w:enabled/>
                                    <w:calcOnExit w:val='0'/>
                                    <w:textInput>
                                        <w:default w:val='date'/>
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
                            <w:t>date</w:t>
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
                        <w:tcW w:w='1116' w:type='dxa'/>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='1170' w:type='dxa'/>
                        <w:tcBorders>
                            <w:right w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                    </w:tcPr>
                    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
                        <w:pPr>
                            <w:jc w:val='center'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                    </w:p>
                </w:tc>
                <w:tc>
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
                        <w:bookmarkStart w:id='1' w:name='Check1'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMCHECKBOX </w:instrText>
                        </w:r>
                        <w:r w:rsidR='004F021A'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:r>
                        <w:r w:rsidR='004F021A'>
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
                        <w:bookmarkEnd w:id='1'/>
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
                        <w:bookmarkStart w:id='2' w:name='Check2'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:instrText xml:space='preserve'> FORMCHECKBOX </w:instrText>
                        </w:r>
                        <w:r w:rsidR='004F021A'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:r>
                        <w:r w:rsidR='004F021A'>
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
                        <w:bookmarkEnd w:id='2'/>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t xml:space='preserve'> Yes # </w:t>
                        </w:r>
                    </w:p>
                </w:tc>
            </w:tr>";
        }
    }
}