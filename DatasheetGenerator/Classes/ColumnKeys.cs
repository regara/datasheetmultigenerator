using System.Collections.Generic;

namespace DatasheetGenerator
{
    public class ColumnKeys
    {
        //////////////////////////  Starting Values (key and setup data)   /////////////////////////
        public List<string> mainContentKeysArr { get; set; }

        public string PHOTO = @"<w:tr w:rsidR='00C834F9' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00C834F9' w:rsidRDefault='00C834F9'>
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
                            <w:t>Photovoltaic</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string HERS = @"<w:tr w:rsidR='00C834F9' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00C834F9' w:rsidRDefault='00C834F9'>
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
                            <w:t>HERS Index Score</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string PLANNAME = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263' w:rsidP='00FE10F0'>
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
                            <w:t id='WALLTYPE'>Plan (WALLTYPE)</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string FILENAME = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='144'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263'>
                        <w:pPr>
                            <w:pStyle w:val='Heading2'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>File Name</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string SQFT = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='144'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263'>
                        <w:pPr>
                            <w:pStyle w:val='Heading2'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:bCs/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:bCs/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>Square Footage</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string ABVP = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='144'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263'>
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
                            <w:t>% Above Code</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string COOLP = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263'>
                        <w:pPr>
                            <w:pStyle w:val='Heading2'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:bCs/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:bCs/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>% Cooling Improvement</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string STORIES = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='144'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263'>
                        <w:pPr>
                            <w:pStyle w:val='Heading2'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:bCs/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:bCs/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>Number of Stories</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string GLAZINGP = @"<w:tr w:rsidR='00282263' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00282263' w:rsidRDefault='00282263'>
                        <w:pPr>
                            <w:pStyle w:val='Heading2'/>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:bCs/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:b w:val='0'/>
                                <w:bCs/>
                                <w:sz w:val='20'/>
                                <w:u w:val='none'/>
                            </w:rPr>
                            <w:t>Glazing Percentage</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string ROOFMAT = @"<w:tr w:rsidR='00467C0D' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00467C0D' w:rsidRDefault='00087037'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:b/>
                                <w:bCs/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:pict>
                                <v:shapetype id='_x0000_t202' coordsize='21600,21600' o:spt='202' path='m,l,21600r21600,l21600,xe'>
                                    <v:stroke joinstyle='miter'/>
                                    <v:path gradientshapeok='t' o:connecttype='rect'/>
                                </v:shapetype>
                                <v:shape id='_x0000_s1176' type='#_x0000_t202' style='position:absolute;margin-left:-27pt;margin-top:1.95pt;width:36pt;height:66.1pt;z-index:1;mso-position-horizontal-relative:text;mso-position-vertical-relative:text' filled='f' stroked='f'>
                                    <v:textbox style='layout-flow:vertical;mso-layout-flow-alt:bottom-to-top;mso-next-textbox:#_x0000_s1176'>
                                        <w:txbxContent>
                                            <w:p w:rsidR='00467C0D' w:rsidRDefault='00467C0D'>
                                                <w:pPr>
                                                    <w:pStyle w:val='Heading8'/>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                        <w:sz w:val='12'/>
                                                    </w:rPr>
                                                </w:pPr>
                                                <w:r>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                    </w:rPr>
                                                    <w:t>Envelope</w:t>
                                                </w:r>
                                            </w:p>
                                        </w:txbxContent>
                                    </v:textbox>
                                </v:shape>
                            </w:pict>
                        </w:r>
                        <w:r w:rsidR='00467C0D'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Roofing Material</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string REFEM = @"<w:tr w:rsidR='00467C0D' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00467C0D' w:rsidRDefault='00467C0D'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Reflectance/</w:t>
                        </w:r>
                        <w:r w:rsidR='000D060A'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Emittance</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string ATTIC = @"<w:tr w:rsidR='00467C0D' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00467C0D' w:rsidRDefault='00467C0D'>
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
                            <w:t>Attic Floor/Vault**</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string ABVRD = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229' w:rsidP='00A36229'>
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
                            <w:t>Attic Above Roof Deck</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string BLWRD = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Attic Below Roof Deck</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string RADIENT = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                                <w:tab w:val='left' w:pos='900'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Radiant Barrier</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string WALL24 = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Wall 2x4</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string WALL26 = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Wall 2x6</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string KNEEWALL = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Knee Wall</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string OVERG = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Floor Over Garage/Exterior</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string FLOORTYPE = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Sub Floor/Slab</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string SEEREER = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='70'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='center'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00087037'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:pict>
                                <v:shape id='_x0000_s1183' type='#_x0000_t202' style='position:absolute;margin-left:-23.2pt;margin-top:-.6pt;width:27pt;height:53.75pt;z-index:2;mso-position-horizontal-relative:text;mso-position-vertical-relative:text' filled='f' stroked='f'>
                                    <v:textbox style='layout-flow:vertical;mso-layout-flow-alt:bottom-to-top;mso-next-textbox:#_x0000_s1183'>
                                        <w:txbxContent>
                                            <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:pStyle w:val='Heading8'/>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                        <w:sz w:val='12'/>
                                                    </w:rPr>
                                                </w:pPr>
                                                <w:r>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                    </w:rPr>
                                                    <w:t>HVAC</w:t>
                                                </w:r>
                                            </w:p>
                                        </w:txbxContent>
                                    </v:textbox>
                                </v:shape>
                            </w:pict>
                        </w:r>
                        <w:r w:rsidR='00A36229'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Minimum SEER/EER Value</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string AFUE = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='center'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Papyrus' w:hAnsi='Papyrus'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Minimum AFUE</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string DUCTINS = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='center'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Duct Insulation</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string WHF = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='center'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Whole House Fan (CFM)</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string FANWAT = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='99'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00087037'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                            </w:rPr>
                            <w:pict>
                                <v:shape id='_x0000_s1184' type='#_x0000_t202' style='position:absolute;margin-left:-27pt;margin-top:6.3pt;width:36pt;height:137.75pt;z-index:3;mso-position-horizontal-relative:text;mso-position-vertical-relative:text' filled='f' stroked='f'>
                                    <v:textbox style='layout-flow:vertical;mso-layout-flow-alt:bottom-to-top;mso-next-textbox:#_x0000_s1184'>
                                        <w:txbxContent>
                                            <w:p w:rsidR='00A36229' w:rsidRPr='006D6F73' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:pStyle w:val='Heading8'/>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                        <w:szCs w:val='24'/>
                                                    </w:rPr>
                                                </w:pPr>
                                                <w:r>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                        <w:szCs w:val='24'/>
                                                    </w:rPr>
                                                    <w:t>HERS Inspections</w:t>
                                                </w:r>
                                            </w:p>
                                            <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:jc w:val='right'/>
                                                    <w:rPr>
                                                        <w:sz w:val='16'/>
                                                    </w:rPr>
                                                </w:pPr>
                                            </w:p>
                                            <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:jc w:val='center'/>
                                                    <w:rPr>
                                                        <w:sz w:val='16'/>
                                                    </w:rPr>
                                                </w:pPr>
                                            </w:p>
                                        </w:txbxContent>
                                    </v:textbox>
                                </v:shape>
                            </w:pict>
                        </w:r>
                        <w:r w:rsidR='00A36229'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Fan Wattage</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string AIRFLOW = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='99'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Airflow (CFM)</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string DUCTTEST = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='90'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Duct Testing Required</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string CFM = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Indoor Air Quality (CFM)</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string REFCHARGE = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t xml:space='preserve'>Refrigerant Charge </w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string SEERVERIF = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>SEER Verification</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string EERVERIF = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>EER Verification</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string INFILTRATION = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='99'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Infiltration (CFM)</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string DUCTCOND = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='99'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Ducts in Conditioned Space</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string LOWLEAK = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Low Leakage Air Handler</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string BURRIEDDUCT = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='162'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Buried Ducts</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string SURFAREA = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Surface Area</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string INSULINSPECT = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='125'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00087037'>
                        <w:pPr>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:noProof/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:pict>
                                <v:shape id='_x0000_s1185' type='#_x0000_t202' style='position:absolute;margin-left:-22.85pt;margin-top:1.55pt;width:27pt;height:63.95pt;z-index:4;mso-position-horizontal-relative:text;mso-position-vertical-relative:text' filled='f' stroked='f'>
                                    <v:textbox style='layout-flow:vertical;mso-layout-flow-alt:bottom-to-top;mso-next-textbox:#_x0000_s1185'>
                                        <w:txbxContent>
                                            <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:jc w:val='center'/>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                    </w:rPr>
                                                </w:pPr>
                                                <w:r>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                    </w:rPr>
                                                    <w:t>H</w:t>
                                                </w:r>
                                                <w:r>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                        <w:vertAlign w:val='subscript'/>
                                                    </w:rPr>
                                                    <w:t>2</w:t>
                                                </w:r>
                                                <w:r>
                                                    <w:rPr>
                                                        <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                                                        <w:b/>
                                                        <w:bCs/>
                                                    </w:rPr>
                                                    <w:t>O</w:t>
                                                </w:r>
                                            </w:p>
                                            <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:jc w:val='right'/>
                                                    <w:rPr>
                                                        <w:sz w:val='12'/>
                                                    </w:rPr>
                                                </w:pPr>
                                            </w:p>
                                            <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                                                <w:pPr>
                                                    <w:jc w:val='center'/>
                                                    <w:rPr>
                                                        <w:sz w:val='12'/>
                                                    </w:rPr>
                                                </w:pPr>
                                            </w:p>
                                        </w:txbxContent>
                                    </v:textbox>
                                </v:shape>
                            </w:pict>
                        </w:r>
                        <w:r w:rsidR='00A36229'>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                                <w:sz w:val='20'/>
                            </w:rPr>
                            <w:t>Insulation Inspection**</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string FUELTYPE = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='144'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:top w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
                        <w:pPr>
                            <w:pStyle w:val='Header'/>
                            <w:tabs>
                                <w:tab w:val='clear' w:pos='4320'/>
                                <w:tab w:val='clear' w:pos='8640'/>
                            </w:tabs>
                        </w:pPr>
                        <w:r>
                            <w:rPr>
                                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                            </w:rPr>
                            <w:t>Fuel Type</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string UEF = @"<w:tr w:rsidR='00A36229' w:rsidTr='00901116'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:shd w:val='clear' w:color='auto' w:fill='auto'/>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Uniform Energy Factor (Tank Size)</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";
        public string DISTRIBUTION = @"<w:tr w:rsidR='00A36229' w:rsidTr='00FC375E'>
                <w:trPr>
                    <w:trHeight w:val='80'/>
                </w:trPr>
                <w:tc>
                    <w:tcPr>
                        <w:tcW w:w='3331' w:type='pct'/>
                        <w:tcBorders>
                            <w:bottom w:val='single' w:sz='4' w:space='0' w:color='auto'/>
                        </w:tcBorders>
                        <w:vAlign w:val='bottom'/>
                    </w:tcPr>
                    <w:p w:rsidR='00A36229' w:rsidRDefault='00A36229'>
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
                            <w:t>Distribution</w:t>
                        </w:r>
                    </w:p>
                </w:tc>";





        public ColumnKeys()
        {
            mainContentKeysArr = new List<string>
            {
                PHOTO, HERS, PLANNAME, FILENAME, SQFT, ABVP, COOLP, STORIES, GLAZINGP, ROOFMAT, REFEM, ATTIC, ABVRD, BLWRD,
                RADIENT, WALL24, WALL26, KNEEWALL, OVERG, FLOORTYPE, SEEREER, AFUE,
                DUCTINS, WHF, FANWAT, AIRFLOW, DUCTTEST, CFM, REFCHARGE, SEERVERIF, EERVERIF, INFILTRATION, DUCTCOND,
                LOWLEAK, BURRIEDDUCT, SURFAREA, INSULINSPECT, FUELTYPE, UEF, DISTRIBUTION
            };
        }


        //////////////////////////  prepares starting values to be entered in the method   //////////////////////////

        
    }
}