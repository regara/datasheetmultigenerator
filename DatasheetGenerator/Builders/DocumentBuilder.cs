﻿using System;
using System.Xml;

namespace DatasheetGenerator
{
    public class DocumentBuilder
    {

        public string Headermsc { get; set; }
        public string FooterMsc { get; set; }

        public string FullXml { get; set; }

        public int Count { get; set; } = MainWindow.Count;
        public XmlDocument Datasheet = new XmlDocument();

                public static int[] colWdithArr =
                {
                    1969,
                    1500,
                    1154,
                    938,
                    749,
                    624,
                    536,
                    469,
                    430,
                    352,
                    293
                };
        
                // COLUMN - <TBLPR>
                public static int[] pageWidthArr =
                {
                    3029,
                    3898,
                    5068,
                    6238,
                    6245,
                    6245,
                    6245,
                    6245,
                    6245,
                    6498,
                    4811
                };
        
                // COLUMNS
                public static int[] keyWidthArr =
                {
                    3331,
                    1997,
                    1536,
                    1248,
                    1247,
                    1246,
                    1245,
                    1246,
                    1125,
                    832,
                    577
                };

                public static int[] KeyFontWeight = {
                    20,
                    20,
                    20,
                    20,
                    20,
                    20,
                    20,
                    20,
                    18,
                    16
                }; 

                public static int[] ColumnFontWeight = {
                    18,
                    18,
                    18,
                    18,
                    18,
                    18,
                    18,
                    18,
                    18,
                    16
                };


        public DocumentBuilder(string header, string columns, string windows)
        {


            //Headermsc
            Headermsc = @"<?xml version='1.0' encoding='UTF-8' standalone='yes'?>
<?mso-application progid='Word.Document'?>
<pkg:package xmlns:pkg='http://schemas.microsoft.com/office/2006/xmlPackage'>
<pkg:part pkg:name='/_rels/.rels' pkg:contentType='application/vnd.openxmlformats-package.relationships+xml' pkg:padding='512'>
<pkg:xmlData>
    <Relationships xmlns='http://schemas.openxmlformats.org/package/2006/relationships'>
    <Relationship Id='rId3' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties' Target='docProps/app.xml'/>
    <Relationship Id='rId2' Type='http://schemas.openxmlformats.org/package/2006/relationships/metadata/core-properties' Target='docProps/core.xml'/>
    <Relationship Id='rId1' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument' Target='word/document.xml'/>
</Relationships>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/_rels/document.xml.rels' pkg:contentType='application/vnd.openxmlformats-package.relationships+xml' pkg:padding='256'>
<pkg:xmlData>
    <Relationships xmlns='http://schemas.openxmlformats.org/package/2006/relationships'>
    <Relationship Id='rId8' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/footer' Target='footer1.xml'/>
    <Relationship Id='rId3' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/settings' Target='settings.xml'/>
    <Relationship Id='rId7' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/image' Target='media/image1.jpeg'/>
    <Relationship Id='rId2' Type='http://schemas.microsoft.com/office/2007/relationships/stylesWithEffects' Target='stylesWithEffects.xml'/>
    <Relationship Id='rId1' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles' Target='styles.xml'/>
    <Relationship Id='rId6' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/endnotes' Target='endnotes.xml'/>
    <Relationship Id='rId5' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/footnotes' Target='footnotes.xml'/>
    <Relationship Id='rId10' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/theme' Target='theme/theme1.xml'/>
    <Relationship Id='rId4' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/webSettings' Target='webSettings.xml'/>
    <Relationship Id='rId9' Type='http://schemas.openxmlformats.org/officeDocument/2006/relationships/fontTable' Target='fontTable.xml'/>
</Relationships>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/document.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml'>
<pkg:xmlData>
    <w:document xmlns:wpc='http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:m='http://schemas.openxmlformats.org/officeDocument/2006/math' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:wp14='http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing' xmlns:wp='http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing' xmlns:w10='urn:schemas-microsoft-com:office:word' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' xmlns:wpg='http://schemas.microsoft.com/office/word/2010/wordprocessingGroup' xmlns:wpi='http://schemas.microsoft.com/office/word/2010/wordprocessingInk' xmlns:wne='http://schemas.microsoft.com/office/word/2006/wordml' xmlns:wps='http://schemas.microsoft.com/office/word/2010/wordprocessingShape' mc:Ignorable='w14 wp14'>
    <w:body>
        <w:tbl>";

            FooterMsc = @"</w:tbl>
        <w:p w:rsidR='00D23B71' w:rsidRPr='006D6F73' w:rsidRDefault='00D23B71'>
            <w:pPr>
                <w:tabs>
                    <w:tab w:val='left' w:pos='5580'/>
                </w:tabs>
                <w:ind w:left='-1080' w:right='-1080'/>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
            </w:pPr>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>NOTE TO BUILDERS:</w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t xml:space='preserve'> A HERS certified Rater is required to perform all tests &amp; inspections.  Section 106.3.5 of the California Building Code (2nd paragraph) says, “The special inspector shall be employed by the owner, the engineer or architect of record, or an agent of the owner, but not the contractor or any other person responsible for the work.”  None of these requirements are waived for any contractor or rater.</w:t>
            </w:r>
        </w:p>
        <w:p w:rsidR='00D23B71' w:rsidRPr='006D6F73' w:rsidRDefault='00D23B71'>
            <w:pPr>
                <w:tabs>
                    <w:tab w:val='left' w:pos='5580'/>
                </w:tabs>
                <w:ind w:left='-1080' w:right='-1080'/>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
            </w:pPr>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>** Due to the stringencies of the California Energy Commission for approved</w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t xml:space='preserve'>
                </w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>methods of quality insulation inspection. California Living &amp; Energy recommends</w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t xml:space='preserve'>
                </w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t xml:space='preserve'>to </w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                    <w:u w:val='single'/>
                </w:rPr>
                <w:t>not</w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t xml:space='preserve'> install batt-insulation in the attic and ceiling areas due to the risk of not meeting the quality insulation inspection requirements.  </w:t>
            </w:r>
        </w:p>
        <w:p w:rsidR='00D23B71' w:rsidRPr='006D6F73' w:rsidRDefault='00D23B71'>
            <w:pPr>
                <w:tabs>
                    <w:tab w:val='left' w:pos='5580'/>
                </w:tabs>
                <w:ind w:left='-1080' w:right='-1080'/>
                <w:rPr>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
            </w:pPr>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>**Builders are strongly encouraged to enforce strict Title 24 compliance with all subcontractor scopes of work.  Modifications to Title 24 specifications during construction may result in complications including but not li</w:t>
            </w:r>
            <w:r w:rsidR='00133320' w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>mited to sampling protocol, CF-3</w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>R closing delays, state registry errors, an</w:t>
            </w:r>
            <w:r w:rsidR='00133320' w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>d/or loss of rebates plus no CF-3</w:t>
            </w:r>
            <w:r w:rsidRPr='006D6F73'>
                <w:rPr>
                    <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
                    <w:b/>
                    <w:sz w:val='12'/>
                    <w:szCs w:val='12'/>
                </w:rPr>
                <w:t>R at final.</w:t>
            </w:r>
        </w:p>
        <w:sectPr w:rsidR='00D23B71' w:rsidRPr='006D6F73'>
            <w:footerReference w:type='default' r:id='rId8'/>
            <w:pgSz w:w='12240' w:h='15840'/>
            <w:pgMar w:top='360' w:right='1800' w:bottom='540' w:left='1800' w:header='720' w:footer='270' w:gutter='0'/>
            <w:cols w:space='720'/>
            <w:docGrid w:linePitch='360'/>
        </w:sectPr>
    </w:body>
</w:document>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/footnotes.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.footnotes+xml'>
<pkg:xmlData>
    <w:footnotes xmlns:wpc='http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:m='http://schemas.openxmlformats.org/officeDocument/2006/math' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:wp14='http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing' xmlns:wp='http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing' xmlns:w10='urn:schemas-microsoft-com:office:word' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' xmlns:wpg='http://schemas.microsoft.com/office/word/2010/wordprocessingGroup' xmlns:wpi='http://schemas.microsoft.com/office/word/2010/wordprocessingInk' xmlns:wne='http://schemas.microsoft.com/office/word/2006/wordml' xmlns:wps='http://schemas.microsoft.com/office/word/2010/wordprocessingShape' mc:Ignorable='w14 wp14'>
    <w:footnote w:type='separator' w:id='-1'>
        <w:p w:rsidR='00DC1C90' w:rsidRDefault='00DC1C90'>
            <w:r>
                <w:separator/>
            </w:r>
        </w:p>
    </w:footnote>
    <w:footnote w:type='continuationSeparator' w:id='0'>
        <w:p w:rsidR='00DC1C90' w:rsidRDefault='00DC1C90'>
            <w:r>
                <w:continuationSeparator/>
            </w:r>
        </w:p>
    </w:footnote>
</w:footnotes>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/endnotes.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.endnotes+xml'>
<pkg:xmlData>
    <w:endnotes xmlns:wpc='http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:m='http://schemas.openxmlformats.org/officeDocument/2006/math' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:wp14='http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing' xmlns:wp='http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing' xmlns:w10='urn:schemas-microsoft-com:office:word' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' xmlns:wpg='http://schemas.microsoft.com/office/word/2010/wordprocessingGroup' xmlns:wpi='http://schemas.microsoft.com/office/word/2010/wordprocessingInk' xmlns:wne='http://schemas.microsoft.com/office/word/2006/wordml' xmlns:wps='http://schemas.microsoft.com/office/word/2010/wordprocessingShape' mc:Ignorable='w14 wp14'>
    <w:endnote w:type='separator' w:id='-1'>
        <w:p w:rsidR='00DC1C90' w:rsidRDefault='00DC1C90'>
            <w:r>
                <w:separator/>
            </w:r>
        </w:p>
    </w:endnote>
    <w:endnote w:type='continuationSeparator' w:id='0'>
        <w:p w:rsidR='00DC1C90' w:rsidRDefault='00DC1C90'>
            <w:r>
                <w:continuationSeparator/>
            </w:r>
        </w:p>
    </w:endnote>
</w:endnotes>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/footer1.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.footer+xml'>
<pkg:xmlData>
    <w:ftr xmlns:wpc='http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:m='http://schemas.openxmlformats.org/officeDocument/2006/math' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:wp14='http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing' xmlns:wp='http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing' xmlns:w10='urn:schemas-microsoft-com:office:word' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' xmlns:wpg='http://schemas.microsoft.com/office/word/2010/wordprocessingGroup' xmlns:wpi='http://schemas.microsoft.com/office/word/2010/wordprocessingInk' xmlns:wne='http://schemas.microsoft.com/office/word/2006/wordml' xmlns:wps='http://schemas.microsoft.com/office/word/2010/wordprocessingShape' mc:Ignorable='w14 wp14'>
    <w:p w:rsidR='00D23B71' w:rsidRDefault='00D23B71'>
        <w:pPr>
            <w:pStyle w:val='Footer'/>
            <w:ind w:left='-1080'/>
        </w:pPr>
        <w:r>
            <w:rPr>
                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                <w:sz w:val='16'/>
            </w:rPr>
            <w:fldChar w:fldCharType='begin'/>
        </w:r>
        <w:r>
            <w:rPr>
                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                <w:sz w:val='16'/>
            </w:rPr>
            <w:instrText xml:space='preserve'> FILENAME \p </w:instrText>
        </w:r>
        <w:r>
            <w:rPr>
                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                <w:sz w:val='16'/>
            </w:rPr>
            <w:fldChar w:fldCharType='separate'/>
        </w:r>
        <w:r>
            <w:rPr>
                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                <w:noProof/>
                <w:sz w:val='16'/>
            </w:rPr>
            <w:t>S:\T24\Data Sheets Templates\2013 Code\2013 Datasheet - 2 Column.doc</w:t>
        </w:r>
        <w:r>
            <w:rPr>
                <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
                <w:sz w:val='16'/>
            </w:rPr>
            <w:fldChar w:fldCharType='end'/>
        </w:r>
    </w:p>
</w:ftr>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/theme/theme1.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.theme+xml'>
<pkg:xmlData>
    <a:theme xmlns:a='http://schemas.openxmlformats.org/drawingml/2006/main' name='Office Theme'>
    <a:themeElements>
        <a:clrScheme name='Office'>
            <a:dk1>
                <a:sysClr val='windowText' lastClr='000000'/>
            </a:dk1>
            <a:lt1>
                <a:sysClr val='window' lastClr='FFFFFF'/>
            </a:lt1>
            <a:dk2>
                <a:srgbClr val='1F497D'/>
            </a:dk2>
            <a:lt2>
                <a:srgbClr val='EEECE1'/>
            </a:lt2>
            <a:accent1>
                <a:srgbClr val='4F81BD'/>
            </a:accent1>
            <a:accent2>
                <a:srgbClr val='C0504D'/>
            </a:accent2>
            <a:accent3>
                <a:srgbClr val='9BBB59'/>
            </a:accent3>
            <a:accent4>
                <a:srgbClr val='8064A2'/>
            </a:accent4>
            <a:accent5>
                <a:srgbClr val='4BACC6'/>
            </a:accent5>
            <a:accent6>
                <a:srgbClr val='F79646'/>
            </a:accent6>
            <a:hlink>
                <a:srgbClr val='0000FF'/>
            </a:hlink>
            <a:folHlink>
                <a:srgbClr val='800080'/>
            </a:folHlink>
        </a:clrScheme>
        <a:fontScheme name='Office'>
            <a:majorFont>
                <a:latin typeface='Cambria'/>
                <a:ea typeface=''/>
                <a:cs typeface=''/>
                <a:font script='Jpan' typeface='ＭＳ ゴシック'/>
                <a:font script='Hang' typeface='맑은 고딕'/>
                <a:font script='Hans' typeface='宋体'/>
                <a:font script='Hant' typeface='新細明體'/>
                <a:font script='Arab' typeface='Times New Roman'/>
                <a:font script='Hebr' typeface='Times New Roman'/>
                <a:font script='Thai' typeface='Angsana New'/>
                <a:font script='Ethi' typeface='Nyala'/>
                <a:font script='Beng' typeface='Vrinda'/>
                <a:font script='Gujr' typeface='Shruti'/>
                <a:font script='Khmr' typeface='MoolBoran'/>
                <a:font script='Knda' typeface='Tunga'/>
                <a:font script='Guru' typeface='Raavi'/>
                <a:font script='Cans' typeface='Euphemia'/>
                <a:font script='Cher' typeface='Plantagenet Cherokee'/>
                <a:font script='Yiii' typeface='Microsoft Yi Baiti'/>
                <a:font script='Tibt' typeface='Microsoft Himalaya'/>
                <a:font script='Thaa' typeface='MV Boli'/>
                <a:font script='Deva' typeface='Mangal'/>
                <a:font script='Telu' typeface='Gautami'/>
                <a:font script='Taml' typeface='Latha'/>
                <a:font script='Syrc' typeface='Estrangelo Edessa'/>
                <a:font script='Orya' typeface='Kalinga'/>
                <a:font script='Mlym' typeface='Kartika'/>
                <a:font script='Laoo' typeface='DokChampa'/>
                <a:font script='Sinh' typeface='Iskoola Pota'/>
                <a:font script='Mong' typeface='Mongolian Baiti'/>
                <a:font script='Viet' typeface='Times New Roman'/>
                <a:font script='Uigh' typeface='Microsoft Uighur'/>
                <a:font script='Geor' typeface='Sylfaen'/>
            </a:majorFont>
            <a:minorFont>
                <a:latin typeface='Calibri'/>
                <a:ea typeface=''/>
                <a:cs typeface=''/>
                <a:font script='Jpan' typeface='ＭＳ 明朝'/>
                <a:font script='Hang' typeface='맑은 고딕'/>
                <a:font script='Hans' typeface='宋体'/>
                <a:font script='Hant' typeface='新細明體'/>
                <a:font script='Arab' typeface='Arial'/>
                <a:font script='Hebr' typeface='Arial'/>
                <a:font script='Thai' typeface='Cordia New'/>
                <a:font script='Ethi' typeface='Nyala'/>
                <a:font script='Beng' typeface='Vrinda'/>
                <a:font script='Gujr' typeface='Shruti'/>
                <a:font script='Khmr' typeface='DaunPenh'/>
                <a:font script='Knda' typeface='Tunga'/>
                <a:font script='Guru' typeface='Raavi'/>
                <a:font script='Cans' typeface='Euphemia'/>
                <a:font script='Cher' typeface='Plantagenet Cherokee'/>
                <a:font script='Yiii' typeface='Microsoft Yi Baiti'/>
                <a:font script='Tibt' typeface='Microsoft Himalaya'/>
                <a:font script='Thaa' typeface='MV Boli'/>
                <a:font script='Deva' typeface='Mangal'/>
                <a:font script='Telu' typeface='Gautami'/>
                <a:font script='Taml' typeface='Latha'/>
                <a:font script='Syrc' typeface='Estrangelo Edessa'/>
                <a:font script='Orya' typeface='Kalinga'/>
                <a:font script='Mlym' typeface='Kartika'/>
                <a:font script='Laoo' typeface='DokChampa'/>
                <a:font script='Sinh' typeface='Iskoola Pota'/>
                <a:font script='Mong' typeface='Mongolian Baiti'/>
                <a:font script='Viet' typeface='Arial'/>
                <a:font script='Uigh' typeface='Microsoft Uighur'/>
                <a:font script='Geor' typeface='Sylfaen'/>
            </a:minorFont>
        </a:fontScheme>
        <a:fmtScheme name='Office'>
            <a:fillStyleLst>
                <a:solidFill>
                    <a:schemeClr val='phClr'/>
                </a:solidFill>
                <a:gradFill rotWithShape='1'>
                    <a:gsLst>
                        <a:gs pos='0'>
                            <a:schemeClr val='phClr'>
                                <a:tint val='50000'/>
                                <a:satMod val='300000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='35000'>
                            <a:schemeClr val='phClr'>
                                <a:tint val='37000'/>
                                <a:satMod val='300000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='100000'>
                            <a:schemeClr val='phClr'>
                                <a:tint val='15000'/>
                                <a:satMod val='350000'/>
                            </a:schemeClr>
                        </a:gs>
                    </a:gsLst>
                    <a:lin ang='16200000' scaled='1'/>
                </a:gradFill>
                <a:gradFill rotWithShape='1'>
                    <a:gsLst>
                        <a:gs pos='0'>
                            <a:schemeClr val='phClr'>
                                <a:shade val='51000'/>
                                <a:satMod val='130000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='80000'>
                            <a:schemeClr val='phClr'>
                                <a:shade val='93000'/>
                                <a:satMod val='130000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='100000'>
                            <a:schemeClr val='phClr'>
                                <a:shade val='94000'/>
                                <a:satMod val='135000'/>
                            </a:schemeClr>
                        </a:gs>
                    </a:gsLst>
                    <a:lin ang='16200000' scaled='0'/>
                </a:gradFill>
            </a:fillStyleLst>
            <a:lnStyleLst>
                <a:ln w='9525' cap='flat' cmpd='sng' algn='ctr'>
                    <a:solidFill>
                        <a:schemeClr val='phClr'>
                            <a:shade val='95000'/>
                            <a:satMod val='105000'/>
                        </a:schemeClr>
                    </a:solidFill>
                    <a:prstDash val='solid'/>
                </a:ln>
                <a:ln w='25400' cap='flat' cmpd='sng' algn='ctr'>
                    <a:solidFill>
                        <a:schemeClr val='phClr'/>
                    </a:solidFill>
                    <a:prstDash val='solid'/>
                </a:ln>
                <a:ln w='38100' cap='flat' cmpd='sng' algn='ctr'>
                    <a:solidFill>
                        <a:schemeClr val='phClr'/>
                    </a:solidFill>
                    <a:prstDash val='solid'/>
                </a:ln>
            </a:lnStyleLst>
            <a:effectStyleLst>
                <a:effectStyle>
                    <a:effectLst>
                        <a:outerShdw blurRad='40000' dist='20000' dir='5400000' rotWithShape='0'>
                            <a:srgbClr val='000000'>
                                <a:alpha val='38000'/>
                            </a:srgbClr>
                        </a:outerShdw>
                    </a:effectLst>
                </a:effectStyle>
                <a:effectStyle>
                    <a:effectLst>
                        <a:outerShdw blurRad='40000' dist='23000' dir='5400000' rotWithShape='0'>
                            <a:srgbClr val='000000'>
                                <a:alpha val='35000'/>
                            </a:srgbClr>
                        </a:outerShdw>
                    </a:effectLst>
                </a:effectStyle>
                <a:effectStyle>
                    <a:effectLst>
                        <a:outerShdw blurRad='40000' dist='23000' dir='5400000' rotWithShape='0'>
                            <a:srgbClr val='000000'>
                                <a:alpha val='35000'/>
                            </a:srgbClr>
                        </a:outerShdw>
                    </a:effectLst>
                    <a:scene3d>
                        <a:camera prst='orthographicFront'>
                            <a:rot lat='0' lon='0' rev='0'/>
                        </a:camera>
                        <a:lightRig rig='threePt' dir='t'>
                            <a:rot lat='0' lon='0' rev='1200000'/>
                        </a:lightRig>
                    </a:scene3d>
                    <a:sp3d>
                        <a:bevelT w='63500' h='25400'/>
                    </a:sp3d>
                </a:effectStyle>
            </a:effectStyleLst>
            <a:bgFillStyleLst>
                <a:solidFill>
                    <a:schemeClr val='phClr'/>
                </a:solidFill>
                <a:gradFill rotWithShape='1'>
                    <a:gsLst>
                        <a:gs pos='0'>
                            <a:schemeClr val='phClr'>
                                <a:tint val='40000'/>
                                <a:satMod val='350000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='40000'>
                            <a:schemeClr val='phClr'>
                                <a:tint val='45000'/>
                                <a:shade val='99000'/>
                                <a:satMod val='350000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='100000'>
                            <a:schemeClr val='phClr'>
                                <a:shade val='20000'/>
                                <a:satMod val='255000'/>
                            </a:schemeClr>
                        </a:gs>
                    </a:gsLst>
                    <a:path path='circle'>
                        <a:fillToRect l='50000' t='-80000' r='50000' b='180000'/>
                    </a:path>
                </a:gradFill>
                <a:gradFill rotWithShape='1'>
                    <a:gsLst>
                        <a:gs pos='0'>
                            <a:schemeClr val='phClr'>
                                <a:tint val='80000'/>
                                <a:satMod val='300000'/>
                            </a:schemeClr>
                        </a:gs>
                        <a:gs pos='100000'>
                            <a:schemeClr val='phClr'>
                                <a:shade val='30000'/>
                                <a:satMod val='200000'/>
                            </a:schemeClr>
                        </a:gs>
                    </a:gsLst>
                    <a:path path='circle'>
                        <a:fillToRect l='50000' t='50000' r='50000' b='50000'/>
                    </a:path>
                </a:gradFill>
            </a:bgFillStyleLst>
        </a:fmtScheme>
    </a:themeElements>
    <a:objectDefaults/>
    <a:extraClrSchemeLst/>
</a:theme>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/media/image1.jpeg' pkg:contentType='image/jpeg' pkg:compression='store'>
<pkg:binaryData>/9j/4AAQSkZJRgABAgEAlgCWAAD/4RuCRXhpZgAATU0AKgAAAAgABwESAAMAAAABAAEAAAEaAAUA
AAABAAAAYgEbAAUAAAABAAAAagEoAAMAAAABAAIAAAExAAIAAAAcAAAAcgEyAAIAAAAUAAAAjodp
AAQAAAABAAAApAAAANAAFuNgAAAnEAAW42AAACcQQWRvYmUgUGhvdG9zaG9wIENTMyBXaW5kb3dz
ADIwMTE6MDQ6MDQgMTU6NDE6NDIAAAAAA6ABAAMAAAABAAEAAKACAAQAAAABAAAAuqADAAQAAAAB
AAAAvAAAAAAAAAAGAQMAAwAAAAEABgAAARoABQAAAAEAAAEeARsABQAAAAEAAAEmASgAAwAAAAEA
AgAAAgEABAAAAAEAAAEuAgIABAAAAAEAABpMAAAAAAAAAEgAAAABAAAASAAAAAH/2P/gABBKRklG
AAECAABIAEgAAP/tAAxBZG9iZV9DTQAB/+4ADkFkb2JlAGSAAAAAAf/bAIQADAgICAkIDAkJDBEL
CgsRFQ8MDA8VGBMTFRMTGBEMDAwMDAwRDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAENCwsN
Dg0QDg4QFA4ODhQUDg4ODhQRDAwMDAwREQwMDAwMDBEMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwM
DAwM/8AAEQgAoACeAwEiAAIRAQMRAf/dAAQACv/EAT8AAAEFAQEBAQEBAAAAAAAAAAMAAQIEBQYH
CAkKCwEAAQUBAQEBAQEAAAAAAAAAAQACAwQFBgcICQoLEAABBAEDAgQCBQcGCAUDDDMBAAIRAwQh
EjEFQVFhEyJxgTIGFJGhsUIjJBVSwWIzNHKC0UMHJZJT8OHxY3M1FqKygyZEk1RkRcKjdDYX0lXi
ZfKzhMPTdePzRieUpIW0lcTU5PSltcXV5fVWZnaGlqa2xtbm9jdHV2d3h5ent8fX5/cRAAICAQIE
BAMEBQYHBwYFNQEAAhEDITESBEFRYXEiEwUygZEUobFCI8FS0fAzJGLhcoKSQ1MVY3M08SUGFqKy
gwcmNcLSRJNUoxdkRVU2dGXi8rOEw9N14/NGlKSFtJXE1OT0pbXF1eX1VmZ2hpamtsbW5vYnN0dX
Z3eHl6e3x//aAAwDAQACEQMRAD8A9VSSSSUpJJJJSkkkklKSSSSUpJVcvqnTcETm5dGKP+GsZX/5
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
AAAAAAABADIAAAABAFoAAAAGAAAAAAABADUAAAABAC0AAAAGAAAAAAABOEJJTQP4AAAAAABwAAD/
////////////////////////////A+gAAAAA/////////////////////////////wPoAAAAAP//
//////////////////////////8D6AAAAAD/////////////////////////////A+gAADhCSU0E
AAAAAAAAAgALOEJJTQQCAAAAAAAaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA4QklNBDAAAAAA
AA0BAQEBAQEBAQEBAQEBADhCSU0ELQAAAAAABgABAAAAGThCSU0ECAAAAAAAEAAAAAEAAAJAAAAC
QAAAAAA4QklNBB4AAAAAAAQAAAAAOEJJTQQaAAAAAANVAAAABgAAAAAAAAAAAAAAvAAAALoAAAAQ
AGQAYQB0AGEAcwBoAGUAZQB0ACAAaABlAGEAZABlAHIAAAABAAAAAAAAAAAAAAAAAAAAAAAAAAEA
AAAAAAAAAAAAALoAAAC8AAAAAAAAAAAAAAAAAAAAAAEAAAAAAAAAAAAAAAAAAAAAAAAAEAAAAAEA
AAAAAABudWxsAAAAAgAAAAZib3VuZHNPYmpjAAAAAQAAAAAAAFJjdDEAAAAEAAAAAFRvcCBsb25n
AAAAAAAAAABMZWZ0bG9uZwAAAAAAAAAAQnRvbWxvbmcAAAC8AAAAAFJnaHRsb25nAAAAugAAAAZz
bGljZXNWbExzAAAAAU9iamMAAAABAAAAAAAFc2xpY2UAAAASAAAAB3NsaWNlSURsb25nAAAAAAAA
AAdncm91cElEbG9uZwAAAAAAAAAGb3JpZ2luZW51bQAAAAxFU2xpY2VPcmlnaW4AAAANYXV0b0dl
bmVyYXRlZAAAAABUeXBlZW51bQAAAApFU2xpY2VUeXBlAAAAAEltZyAAAAAGYm91bmRzT2JqYwAA
AAEAAAAAAABSY3QxAAAABAAAAABUb3AgbG9uZwAAAAAAAAAATGVmdGxvbmcAAAAAAAAAAEJ0b21s
b25nAAAAvAAAAABSZ2h0bG9uZwAAALoAAAADdXJsVEVYVAAAAAEAAAAAAABudWxsVEVYVAAAAAEA
AAAAAABNc2dlVEVYVAAAAAEAAAAAAAZhbHRUYWdURVhUAAAAAQAAAAAADmNlbGxUZXh0SXNIVE1M
Ym9vbAEAAAAIY2VsbFRleHRURVhUAAAAAQAAAAAACWhvcnpBbGlnbmVudW0AAAAPRVNsaWNlSG9y
ekFsaWduAAAAB2RlZmF1bHQAAAAJdmVydEFsaWduZW51bQAAAA9FU2xpY2VWZXJ0QWxpZ24AAAAH
ZGVmYXVsdAAAAAtiZ0NvbG9yVHlwZWVudW0AAAARRVNsaWNlQkdDb2xvclR5cGUAAAAATm9uZQAA
AAl0b3BPdXRzZXRsb25nAAAAAAAAAApsZWZ0T3V0c2V0bG9uZwAAAAAAAAAMYm90dG9tT3V0c2V0
bG9uZwAAAAAAAAALcmlnaHRPdXRzZXRsb25nAAAAAAA4QklNBCgAAAAAAAwAAAABP/AAAAAAAAA4
QklNBBQAAAAAAAQAAAAaOEJJTQQMAAAAABpoAAAAAQAAAJ4AAACgAAAB3AABKYAAABpMABgAAf/Y
/+AAEEpGSUYAAQIAAEgASAAA/+0ADEFkb2JlX0NNAAH/7gAOQWRvYmUAZIAAAAAB/9sAhAAMCAgI
CQgMCQkMEQsKCxEVDwwMDxUYExMVExMYEQwMDAwMDBEMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwM
DAwMAQ0LCw0ODRAODhAUDg4OFBQODg4OFBEMDAwMDBERDAwMDAwMEQwMDAwMDAwMDAwMDAwMDAwM
DAwMDAwMDAwMDAz/wAARCACgAJ4DASIAAhEBAxEB/90ABAAK/8QBPwAAAQUBAQEBAQEAAAAAAAAA
AwABAgQFBgcICQoLAQABBQEBAQEBAQAAAAAAAAABAAIDBAUGBwgJCgsQAAEEAQMCBAIFBwYIBQMM
MwEAAhEDBCESMQVBUWETInGBMgYUkaGxQiMkFVLBYjM0coLRQwclklPw4fFjczUWorKDJkSTVGRF
wqN0NhfSVeJl8rOEw9N14/NGJ5SkhbSVxNTk9KW1xdXl9VZmdoaWprbG1ub2N0dXZ3eHl6e3x9fn
9xEAAgIBAgQEAwQFBgcHBgU1AQACEQMhMRIEQVFhcSITBTKBkRShsUIjwVLR8DMkYuFygpJDUxVj
czTxJQYWorKDByY1wtJEk1SjF2RFVTZ0ZeLys4TD03Xj80aUpIW0lcTU5PSltcXV5fVWZnaGlqa2
xtbm9ic3R1dnd4eXp7fH/9oADAMBAAIRAxEAPwD1VJJJJSkkkklKSSSSUpJJJJSklVy+qdNwRObl
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
hFMAAAAARlN0c1ZsTHMAAAABT2JqYwAAAAEAAAAAAABudWxsAAAABAAAAABGc0lEbG9uZwAAAAAA
AAAAQUZybWxvbmcAAAAAAAAAAEZzRnJWbExzAAAAAWxvbmcpMoRTAAAAAExDbnRsb25nAAAAAAAA
OEJJTVJvbGwAAAAIAAAAAAAAAAA4QklND6EAAAAAABxtZnJpAAAAAgAAABAAAAABAAAAAAAAAAEA
AAAAOEJJTQQGAAAAAAAHAAgAAAABAQD/4Q/QaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wLwA8
P3hwYWNrZXQgYmVnaW49Iu+7vyIgaWQ9Ilc1TTBNcENlaGlIenJlU3pOVGN6a2M5ZCI/PiA8eDp4
bXBtZXRhIHhtbG5zOng9ImFkb2JlOm5zOm1ldGEvIiB4OnhtcHRrPSJBZG9iZSBYTVAgQ29yZSA0
LjEtYzAzNiA0Ni4yNzY3MjAsIE1vbiBGZWIgMTkgMjAwNyAyMjo0MDowOCAgICAgICAgIj4gPHJk
ZjpSREYgeG1sbnM6cmRmPSJodHRwOi8vd3d3LnczLm9yZy8xOTk5LzAyLzIyLXJkZi1zeW50YXgt
bnMjIj4gPHJkZjpEZXNjcmlwdGlvbiByZGY6YWJvdXQ9IiIgeG1sbnM6ZGM9Imh0dHA6Ly9wdXJs
Lm9yZy9kYy9lbGVtZW50cy8xLjEvIiB4bWxuczp4YXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFw
LzEuMC8iIHhtbG5zOnhhcE1NPSJodHRwOi8vbnMuYWRvYmUuY29tL3hhcC8xLjAvbW0vIiB4bWxu
czpzdFJlZj0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL3NUeXBlL1Jlc291cmNlUmVmIyIg
eG1sbnM6dGlmZj0iaHR0cDovL25zLmFkb2JlLmNvbS90aWZmLzEuMC8iIHhtbG5zOmV4aWY9Imh0
dHA6Ly9ucy5hZG9iZS5jb20vZXhpZi8xLjAvIiB4bWxuczpwaG90b3Nob3A9Imh0dHA6Ly9ucy5h
ZG9iZS5jb20vcGhvdG9zaG9wLzEuMC8iIGRjOmZvcm1hdD0iaW1hZ2UvanBlZyIgeGFwOkNyZWF0
b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ1MzIFdpbmRvd3MiIHhhcDpDcmVhdGVEYXRlPSIyMDEx
LTA0LTA0VDE1OjQxOjQyLTA3OjAwIiB4YXA6TW9kaWZ5RGF0ZT0iMjAxMS0wNC0wNFQxNTo0MTo0
Mi0wNzowMCIgeGFwOk1ldGFkYXRhRGF0ZT0iMjAxMS0wNC0wNFQxNTo0MTo0Mi0wNzowMCIgeGFw
TU06RG9jdW1lbnRJRD0idXVpZDpBMzZEMTI0NTBDNUZFMDExQTY5NjkyRkU2RjMwNEE0QSIgeGFw
TU06SW5zdGFuY2VJRD0idXVpZDpBNDZEMTI0NTBDNUZFMDExQTY5NjkyRkU2RjMwNEE0QSIgdGlm
ZjpPcmllbnRhdGlvbj0iMSIgdGlmZjpYUmVzb2x1dGlvbj0iMTUwMDAwMC8xMDAwMCIgdGlmZjpZ
UmVzb2x1dGlvbj0iMTUwMDAwMC8xMDAwMCIgdGlmZjpSZXNvbHV0aW9uVW5pdD0iMiIgdGlmZjpO
YXRpdmVEaWdlc3Q9IjI1NiwyNTcsMjU4LDI1OSwyNjIsMjc0LDI3NywyODQsNTMwLDUzMSwyODIs
MjgzLDI5NiwzMDEsMzE4LDMxOSw1MjksNTMyLDMwNiwyNzAsMjcxLDI3MiwzMDUsMzE1LDMzNDMy
O0Q3NjlGODI2MzFCMzAwMTNCNTM4QjMwREVERDEwNjhBIiBleGlmOlBpeGVsWERpbWVuc2lvbj0i
MTg2IiBleGlmOlBpeGVsWURpbWVuc2lvbj0iMTg4IiBleGlmOkNvbG9yU3BhY2U9IjEiIGV4aWY6
TmF0aXZlRGlnZXN0PSIzNjg2NCw0MDk2MCw0MDk2MSwzNzEyMSwzNzEyMiw0MDk2Miw0MDk2Mywz
NzUxMCw0MDk2NCwzNjg2NywzNjg2OCwzMzQzNCwzMzQzNywzNDg1MCwzNDg1MiwzNDg1NSwzNDg1
NiwzNzM3NywzNzM3OCwzNzM3OSwzNzM4MCwzNzM4MSwzNzM4MiwzNzM4MywzNzM4NCwzNzM4NSwz
NzM4NiwzNzM5Niw0MTQ4Myw0MTQ4NCw0MTQ4Niw0MTQ4Nyw0MTQ4OCw0MTQ5Miw0MTQ5Myw0MTQ5
NSw0MTcyOCw0MTcyOSw0MTczMCw0MTk4NSw0MTk4Niw0MTk4Nyw0MTk4OCw0MTk4OSw0MTk5MCw0
MTk5MSw0MTk5Miw0MTk5Myw0MTk5NCw0MTk5NSw0MTk5Niw0MjAxNiwwLDIsNCw1LDYsNyw4LDks
MTAsMTEsMTIsMTMsMTQsMTUsMTYsMTcsMTgsMjAsMjIsMjMsMjQsMjUsMjYsMjcsMjgsMzA7NUIx
OUVEN0UyM0JDMzM5RUMzMDk1MEI5QUFBRTZCRTciIHBob3Rvc2hvcDpDb2xvck1vZGU9IjMiIHBo
b3Rvc2hvcDpJQ0NQcm9maWxlPSJzUkdCIElFQzYxOTY2LTIuMSIgcGhvdG9zaG9wOkhpc3Rvcnk9
IiI+IDx4YXBNTTpEZXJpdmVkRnJvbSBzdFJlZjppbnN0YW5jZUlEPSJ1dWlkOkEwNkQxMjQ1MEM1
RkUwMTFBNjk2OTJGRTZGMzA0QTRBIiBzdFJlZjpkb2N1bWVudElEPSJ1dWlkOjg1MzBEMzNFMEI1
RkUwMTFBNjk2OTJGRTZGMzA0QTRBIi8+IDwvcmRmOkRlc2NyaXB0aW9uPiA8L3JkZjpSREY+IDwv
eDp4bXBtZXRhPiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAg
ICAgICAgIDw/eHBhY2tldCBlbmQ9InciPz7/4gxYSUNDX1BST0ZJTEUAAQEAAAxITGlubwIQAABt
bnRyUkdCIFhZWiAHzgACAAkABgAxAABhY3NwTVNGVAAAAABJRUMgc1JHQgAAAAAAAAAAAAAAAQAA
9tYAAQAAAADTLUhQICAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
AAAAABFjcHJ0AAABUAAAADNkZXNjAAABhAAAAGx3dHB0AAAB8AAAABRia3B0AAACBAAAABRyWFla
AAACGAAAABRnWFlaAAACLAAAABRiWFlaAAACQAAAABRkbW5kAAACVAAAAHBkbWRkAAACxAAAAIh2
dWVkAAADTAAAAIZ2aWV3AAAD1AAAACRsdW1pAAAD+AAAABRtZWFzAAAEDAAAACR0ZWNoAAAEMAAA
AAxyVFJDAAAEPAAACAxnVFJDAAAEPAAACAxiVFJDAAAEPAAACAx0ZXh0AAAAAENvcHlyaWdodCAo
YykgMTk5OCBIZXdsZXR0LVBhY2thcmQgQ29tcGFueQAAZGVzYwAAAAAAAAASc1JHQiBJRUM2MTk2
Ni0yLjEAAAAAAAAAAAAAABJzUkdCIElFQzYxOTY2LTIuMQAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAWFlaIAAAAAAAAPNRAAEAAAABFsxYWVogAAAAAAAA
AAAAAAAAAAAAAFhZWiAAAAAAAABvogAAOPUAAAOQWFlaIAAAAAAAAGKZAAC3hQAAGNpYWVogAAAA
AAAAJKAAAA+EAAC2z2Rlc2MAAAAAAAAAFklFQyBodHRwOi8vd3d3LmllYy5jaAAAAAAAAAAAAAAA
FklFQyBodHRwOi8vd3d3LmllYy5jaAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
AAAAAAAAAAAAAABkZXNjAAAAAAAAAC5JRUMgNjE5NjYtMi4xIERlZmF1bHQgUkdCIGNvbG91ciBz
cGFjZSAtIHNSR0IAAAAAAAAAAAAAAC5JRUMgNjE5NjYtMi4xIERlZmF1bHQgUkdCIGNvbG91ciBz
cGFjZSAtIHNSR0IAAAAAAAAAAAAAAAAAAAAAAAAAAAAAZGVzYwAAAAAAAAAsUmVmZXJlbmNlIFZp
ZXdpbmcgQ29uZGl0aW9uIGluIElFQzYxOTY2LTIuMQAAAAAAAAAAAAAALFJlZmVyZW5jZSBWaWV3
aW5nIENvbmRpdGlvbiBpbiBJRUM2MTk2Ni0yLjEAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAHZp
ZXcAAAAAABOk/gAUXy4AEM8UAAPtzAAEEwsAA1yeAAAAAVhZWiAAAAAAAEwJVgBQAAAAVx/nbWVh
cwAAAAAAAAABAAAAAAAAAAAAAAAAAAAAAAAAAo8AAAACc2lnIAAAAABDUlQgY3VydgAAAAAAAAQA
AAAABQAKAA8AFAAZAB4AIwAoAC0AMgA3ADsAQABFAEoATwBUAFkAXgBjAGgAbQByAHcAfACBAIYA
iwCQAJUAmgCfAKQAqQCuALIAtwC8AMEAxgDLANAA1QDbAOAA5QDrAPAA9gD7AQEBBwENARMBGQEf
ASUBKwEyATgBPgFFAUwBUgFZAWABZwFuAXUBfAGDAYsBkgGaAaEBqQGxAbkBwQHJAdEB2QHhAekB
8gH6AgMCDAIUAh0CJgIvAjgCQQJLAlQCXQJnAnECegKEAo4CmAKiAqwCtgLBAssC1QLgAusC9QMA
AwsDFgMhAy0DOANDA08DWgNmA3IDfgOKA5YDogOuA7oDxwPTA+AD7AP5BAYEEwQgBC0EOwRIBFUE
YwRxBH4EjASaBKgEtgTEBNME4QTwBP4FDQUcBSsFOgVJBVgFZwV3BYYFlgWmBbUFxQXVBeUF9gYG
BhYGJwY3BkgGWQZqBnsGjAadBq8GwAbRBuMG9QcHBxkHKwc9B08HYQd0B4YHmQesB78H0gflB/gI
CwgfCDIIRghaCG4IggiWCKoIvgjSCOcI+wkQCSUJOglPCWQJeQmPCaQJugnPCeUJ+woRCicKPQpU
CmoKgQqYCq4KxQrcCvMLCwsiCzkLUQtpC4ALmAuwC8gL4Qv5DBIMKgxDDFwMdQyODKcMwAzZDPMN
DQ0mDUANWg10DY4NqQ3DDd4N+A4TDi4OSQ5kDn8Omw62DtIO7g8JDyUPQQ9eD3oPlg+zD88P7BAJ
ECYQQxBhEH4QmxC5ENcQ9RETETERTxFtEYwRqhHJEegSBxImEkUSZBKEEqMSwxLjEwMTIxNDE2MT
gxOkE8UT5RQGFCcUSRRqFIsUrRTOFPAVEhU0FVYVeBWbFb0V4BYDFiYWSRZsFo8WshbWFvoXHRdB
F2UXiReuF9IX9xgbGEAYZRiKGK8Y1Rj6GSAZRRlrGZEZtxndGgQaKhpRGncanhrFGuwbFBs7G2Mb
ihuyG9ocAhwqHFIcexyjHMwc9R0eHUcdcB2ZHcMd7B4WHkAeah6UHr4e6R8THz4faR+UH78f6iAV
IEEgbCCYIMQg8CEcIUghdSGhIc4h+yInIlUigiKvIt0jCiM4I2YjlCPCI/AkHyRNJHwkqyTaJQkl
OCVoJZclxyX3JicmVyaHJrcm6CcYJ0kneierJ9woDSg/KHEooijUKQYpOClrKZ0p0CoCKjUqaCqb
Ks8rAis2K2krnSvRLAUsOSxuLKIs1y0MLUEtdi2rLeEuFi5MLoIuty7uLyQvWi+RL8cv/jA1MGww
pDDbMRIxSjGCMbox8jIqMmMymzLUMw0zRjN/M7gz8TQrNGU0njTYNRM1TTWHNcI1/TY3NnI2rjbp
NyQ3YDecN9c4FDhQOIw4yDkFOUI5fzm8Ofk6Njp0OrI67zstO2s7qjvoPCc8ZTykPOM9Ij1hPaE9
4D4gPmA+oD7gPyE/YT+iP+JAI0BkQKZA50EpQWpBrEHuQjBCckK1QvdDOkN9Q8BEA0RHRIpEzkUS
RVVFmkXeRiJGZ0arRvBHNUd7R8BIBUhLSJFI10kdSWNJqUnwSjdKfUrESwxLU0uaS+JMKkxyTLpN
Ak1KTZNN3E4lTm5Ot08AT0lPk0/dUCdQcVC7UQZRUFGbUeZSMVJ8UsdTE1NfU6pT9lRCVI9U21Uo
VXVVwlYPVlxWqVb3V0RXklfgWC9YfVjLWRpZaVm4WgdaVlqmWvVbRVuVW+VcNVyGXNZdJ114Xcle
Gl5sXr1fD19hX7NgBWBXYKpg/GFPYaJh9WJJYpxi8GNDY5dj62RAZJRk6WU9ZZJl52Y9ZpJm6Gc9
Z5Nn6Wg/aJZo7GlDaZpp8WpIap9q92tPa6dr/2xXbK9tCG1gbbluEm5rbsRvHm94b9FwK3CGcOBx
OnGVcfByS3KmcwFzXXO4dBR0cHTMdSh1hXXhdj52m3b4d1Z3s3gReG54zHkqeYl553pGeqV7BHtj
e8J8IXyBfOF9QX2hfgF+Yn7CfyN/hH/lgEeAqIEKgWuBzYIwgpKC9INXg7qEHYSAhOOFR4Wrhg6G
cobXhzuHn4gEiGmIzokziZmJ/opkisqLMIuWi/yMY4zKjTGNmI3/jmaOzo82j56QBpBukNaRP5Go
khGSepLjk02TtpQglIqU9JVflcmWNJaflwqXdZfgmEyYuJkkmZCZ/JpomtWbQpuvnByciZz3nWSd
0p5Anq6fHZ+Ln/qgaaDYoUehtqImopajBqN2o+akVqTHpTilqaYapoum/adup+CoUqjEqTepqaoc
qo+rAqt1q+msXKzQrUStuK4trqGvFq+LsACwdbDqsWCx1rJLssKzOLOutCW0nLUTtYq2AbZ5tvC3
aLfguFm40blKucK6O7q1uy67p7whvJu9Fb2Pvgq+hL7/v3q/9cBwwOzBZ8Hjwl/C28NYw9TEUcTO
xUvFyMZGxsPHQce/yD3IvMk6ybnKOMq3yzbLtsw1zLXNNc21zjbOts83z7jQOdC60TzRvtI/0sHT
RNPG1EnUy9VO1dHWVdbY11zX4Nhk2OjZbNnx2nba+9uA3AXcit0Q3ZbeHN6i3ynfr+A24L3hROHM
4lPi2+Nj4+vkc+T85YTmDeaW5x/nqegy6LzpRunQ6lvq5etw6/vshu0R7ZzuKO6070DvzPBY8OXx
cvH/8ozzGfOn9DT0wvVQ9d72bfb794r4Gfio+Tj5x/pX+uf7d/wH/Jj9Kf26/kv+3P9t////7gAO
QWRvYmUAZEAAAAAB/9sAhAABAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEBAQEB
AQEBAgICAgICAgICAgIDAwMDAwMDAwMDAQEBAQEBAQEBAQECAgECAgMDAwMDAwMDAwMDAwMDAwMD
AwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwP/wAARCAC8ALoDAREAAhEBAxEB/90ABAAY
/8QBogAAAAYCAwEAAAAAAAAAAAAABwgGBQQJAwoCAQALAQAABgMBAQEAAAAAAAAAAAAGBQQDBwII
AQkACgsQAAIBAwQBAwMCAwMDAgYJdQECAwQRBRIGIQcTIgAIMRRBMiMVCVFCFmEkMxdScYEYYpEl
Q6Gx8CY0cgoZwdE1J+FTNoLxkqJEVHNFRjdHYyhVVlcassLS4vJkg3SThGWjs8PT4yk4ZvN1Kjk6
SElKWFlaZ2hpanZ3eHl6hYaHiImKlJWWl5iZmqSlpqeoqaq0tba3uLm6xMXGx8jJytTV1tfY2drk
5ebn6Onq9PX29/j5+hEAAgEDAgQEAwUEBAQGBgVtAQIDEQQhEgUxBgAiE0FRBzJhFHEIQoEjkRVS
oWIWMwmxJMHRQ3LwF+GCNCWSUxhjRPGisiY1GVQ2RWQnCnODk0Z0wtLi8lVldVY3hIWjs8PT4/Mp
GpSktMTU5PSVpbXF1eX1KEdXZjh2hpamtsbW5vZnd4eXp7fH1+f3SFhoeIiYqLjI2Oj4OUlZaXmJ
mam5ydnp+So6SlpqeoqaqrrK2ur6/9oADAMBAAIRAxEAPwDf49+691737r3Xvfuvde9+691737r3
Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9
+691737r3Xvfuvde9+691737r3Xvfuvdf//Q3+Pfuvde9+691737r3Xvfuvde9+691737r3Xvfuv
de9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+6917
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
xP8Ajr0/RR0XX/Umy8GkbFvuFwtHU1bsWLapKmoikkYgn37rZJPn0PUGMx1KoSmx9FToosEgpYIl
A/oFjjUAe/da6ypSUkcnmjpaeOW2nypDGslv6a1UNb/Y+/de61k/+FLv8uHcXyN+NuB+bfxwhyG3
/mN8Ga+Lt7Ym5tqIafdmb2btirpdw7iwtFUUw+4qctt98XHmsUumWT7uhMESj7qTV7rfVmf8nv8A
mF7d/mY/BHp/5I0j0FJv6TG/3K7p23QsQm2e29qQwUO7aOKnd5JafGZaVo8njw7M5x1dAWOon37r
x6tB9+611737r3X/19/j37r3XvfuvdfOJzXb8P8AMu/nK/MT5359o9z/AB5+HklT0b8eqSadqvA1
+E67yEu3cZkMTK4eNKbsbe2Rny7FAXFLuWUEWhHs95a2Z+YN827alJCSv3EeSL3Of95Bp86dE3MO
7psOybjurULxp2D1du1R/vRFflXofajKVmVyFblMhUSVeQyVZU19dVS28lTWVk71FVPJpCr5Jp5C
xsALn3mjFDFbwxQQoFhRQqgcAAKAD5AY6w7mlknllnmctK7FmJ4kk1JP2k56daWb6c+7HprpTUk/
05/33++PvXVelXRVH0591PWulhQ1P0596PWqdLOgqf08+69V663T2HiNi42mq6+OtyOSyVSuO29t
zEwfeZ3ceWlA8OOxNEpBlkYkF5GKxRKbuwuLkPMHMO28t2DX24y0HBEGXdv4VH+EnAGSR0ecvcub
nzNfrYbbHU8Xc4SNf4mP+ACpY8Ac9Ha+PP8ALF7s+S9NQ73+U+4sl1d1pXrHV4vpfadXLS5HI0Eg
V4hu/Kp4qqveZLa430wg8rEh59408y8+b5zE8kbTGDbTwiQkAj+m2C5+2i+ijrJnlrkPYeWkjkSA
XG5jjNIASD/QXIQelO71Y9XldHfEz4//AB0x9LRdT9bbe21PSwLTnLw0cUmZnULpZp8i6mocv+ef
YJ6GhYniejG+/da697917r3v3Xuve/de697917r3v3Xuve/de697917qNW0dLkaOqoK2COpo62nm
paqnlUPFPTzxtFNFIjAqySRsQQfqD7917rSO/lntUfye/wDhQD8qv5amQkfCfGj5sUX+nP42UE5l
pcNjMzURZbcWGxGChmkNNDBS42mz23pXDNJP/dyiU8kAe63x63evfutde9+691//0N/j37r3VZv8
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
i27MlFvTeNJChAZ2lxND6fyv1Et8t/dr9o+XXinbl0392n47xzMD9sXbAfzi6Hu1+3vKu2aGXbzP
KPxTMX/4zhP+M9CD1p1B/Nk+ZOUGC6s2bivi7tbLsYZ5OpsPkd0drVlFUWjjfJdn5DJ5TJ42rFOz
B5sfmMLyfVTG1hONpaWlhbxWdjaxw2iCipGqoij0VVAAHyA6GkcSxIsUaKkQ4BQAB9gHV+XwC/4S
v7W2ZmKDs35J5WoyG6qmrXMZCuz9eN3b9rMjKzzVNQ+Uqolx2Eq55Jn1z00IrGDEPO/19qerVVeG
T1tv9E/Gbpf437ap9sdTbIxG26aKNEqK6GmjfK5CRRZpq3IOpqJpHPJubXPv3VSSeJ6Hr37rXXvf
uvde9+691737r3Xvfuvde9+691//1d/j37r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvd
Jnc2zNpbzoZcZuvbeF3FQToY5abL46lro2RvqtqiJyAf8Le/de4dVx93/wAnf4Ed8Q1Kbq6S29Qz
1JdmlxVJTRwhpOWb7GeKWka55sVt791fWeqiO6f+Em3wW3xFVy7EDbRrJ2d0FPh8TQ6Xe5/zuOpY
R9fzpv791rUPNeq9c7/wjS2fLVSSYXs0pDqbxrJmaqEaebXQUjLf37PXjoIoQepO2v8AhG7tChqo
pMv2FR1UKurOs2VrqxWAtcGNoY1I/wAPp791uqeh6sc6X/4SufDDY0dHPu9MVlq+ntrmoNo7ckqm
/wBVpyOQx1RVoSR9VYH37r2oDgo6tj6h/lCfB3qCKi/h/VdLuWpoAgp59zymvhQJbSEobLSxqLfR
VA9+61rbqxDauxdm7HoIcXs/a+C21QU6COKmw2MpKGNEUWC/sRIxAH9Sffuqkk8elX7917r3v3Xu
ve/de697917r3v3Xuve/de697917r3v3Xuv/1t/j37r3Xvfuvde9+691737r3Xvfuvde9+691737
r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvde9+691737r3Xvfuvd
e9+691737r3Xvfuvde9+691//9k=</pkg:binaryData>
</pkg:part>
<pkg:part pkg:name='/word/settings.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.settings+xml'>
<pkg:xmlData>
    <w:settings xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:m='http://schemas.openxmlformats.org/officeDocument/2006/math' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:w10='urn:schemas-microsoft-com:office:word' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' xmlns:sl='http://schemas.openxmlformats.org/schemaLibrary/2006/main' mc:Ignorable='w14'>
    <w:zoom w:percent='100'/>
    <w:doNotTrackMoves/>
    <w:defaultTabStop w:val='720'/>
    <w:noPunctuationKerning/>
    <w:characterSpacingControl w:val='doNotCompress'/>
    <w:footnotePr>
        <w:footnote w:id='-1'/>
        <w:footnote w:id='0'/>
    </w:footnotePr>
    <w:endnotePr>
        <w:endnote w:id='-1'/>
        <w:endnote w:id='0'/>
    </w:endnotePr>
    <w:compat>
        <w:doNotBreakWrappedTables/>
        <w:doNotSnapToGridInCell/>
        <w:selectFldWithFirstOrLastChar/>
        <w:doNotWrapTextWithPunct/>
        <w:doNotUseEastAsianBreakRules/>
        <w:useWord2002TableStyleRules/>
        <w:growAutofit/>
        <w:useNormalStyleForList/>
        <w:doNotUseIndentAsNumberingTabStop/>
        <w:useAltKinsokuLineBreakRules/>
        <w:allowSpaceOfSameStyleInTable/>
        <w:doNotSuppressIndentation/>
        <w:doNotAutofitConstrainedTables/>
        <w:autofitToFirstFixedWidthCell/>
        <w:underlineTabInNumList/>
        <w:displayHangulFixedWidth/>
        <w:splitPgBreakAndParaMark/>
        <w:doNotVertAlignCellWithSp/>
        <w:doNotBreakConstrainedForcedTable/>
        <w:doNotVertAlignInTxbx/>
        <w:useAnsiKerningPairs/>
        <w:cachedColBalance/>
        <w:compatSetting w:name='compatibilityMode' w:uri='http://schemas.microsoft.com/office/word' w:val='11'/>
    </w:compat>
    <w:rsids>
        <w:rsidRoot w:val='00E018E8'/>
        <w:rsid w:val='000D060A'/>
        <w:rsid w:val='000E6A10'/>
        <w:rsid w:val='000F6CC0'/>
        <w:rsid w:val='00124FE9'/>
        <w:rsid w:val='00133320'/>
        <w:rsid w:val='001F5D12'/>
        <w:rsid w:val='001F6CF8'/>
        <w:rsid w:val='00203CF0'/>
        <w:rsid w:val='0023262D'/>
        <w:rsid w:val='00282263'/>
        <w:rsid w:val='00286F65'/>
        <w:rsid w:val='00292017'/>
        <w:rsid w:val='00322BAF'/>
        <w:rsid w:val='0038206D'/>
        <w:rsid w:val='004145D5'/>
        <w:rsid w:val='0042727A'/>
        <w:rsid w:val='00467C0D'/>
        <w:rsid w:val='00494F19'/>
        <w:rsid w:val='004B4CD7'/>
        <w:rsid w:val='004C490E'/>
        <w:rsid w:val='004E024B'/>
        <w:rsid w:val='00532E3B'/>
        <w:rsid w:val='00563E5C'/>
        <w:rsid w:val='00572CD5'/>
        <w:rsid w:val='0057386C'/>
        <w:rsid w:val='00590613'/>
        <w:rsid w:val='005A62E5'/>
        <w:rsid w:val='005C03A5'/>
        <w:rsid w:val='005D593F'/>
        <w:rsid w:val='00622F09'/>
        <w:rsid w:val='006C745B'/>
        <w:rsid w:val='006D6F73'/>
        <w:rsid w:val='006E1C58'/>
        <w:rsid w:val='006E2274'/>
        <w:rsid w:val='006F6775'/>
        <w:rsid w:val='00716513'/>
        <w:rsid w:val='00817E8D'/>
        <w:rsid w:val='00861443'/>
        <w:rsid w:val='008A3516'/>
        <w:rsid w:val='00901116'/>
        <w:rsid w:val='00914550'/>
        <w:rsid w:val='00922B5B'/>
        <w:rsid w:val='00943EB5'/>
        <w:rsid w:val='009D462A'/>
        <w:rsid w:val='009E6211'/>
        <w:rsid w:val='009F3AD7'/>
        <w:rsid w:val='00A12865'/>
        <w:rsid w:val='00A31FB0'/>
        <w:rsid w:val='00A354B8'/>
        <w:rsid w:val='00A36229'/>
        <w:rsid w:val='00A51388'/>
        <w:rsid w:val='00A8501F'/>
        <w:rsid w:val='00AA352C'/>
        <w:rsid w:val='00AD0BAD'/>
        <w:rsid w:val='00B307B8'/>
        <w:rsid w:val='00B67EDC'/>
        <w:rsid w:val='00BC56A9'/>
        <w:rsid w:val='00C137AE'/>
        <w:rsid w:val='00C66267'/>
        <w:rsid w:val='00C834F9'/>
        <w:rsid w:val='00D23B71'/>
        <w:rsid w:val='00D90AA6'/>
        <w:rsid w:val='00DC1C90'/>
        <w:rsid w:val='00DE32FA'/>
        <w:rsid w:val='00DF61BA'/>
        <w:rsid w:val='00E018E8'/>
        <w:rsid w:val='00E8704F'/>
        <w:rsid w:val='00F219CC'/>
        <w:rsid w:val='00FC375E'/>
        <w:rsid w:val='00FE10F0'/>
        <w:rsid w:val='00FF3E50'/>
    </w:rsids>
    <m:mathPr>
        <m:mathFont m:val='Cambria Math'/>
        <m:brkBin m:val='before'/>
        <m:brkBinSub m:val='--'/>
        <m:smallFrac m:val='0'/>
        <m:dispDef/>
        <m:lMargin m:val='0'/>
        <m:rMargin m:val='0'/>
        <m:defJc m:val='centerGroup'/>
        <m:wrapIndent m:val='1440'/>
        <m:intLim m:val='subSup'/>
        <m:naryLim m:val='undOvr'/>
    </m:mathPr>
    <w:themeFontLang w:val='en-US'/>
    <w:clrSchemeMapping w:bg1='light1' w:t1='dark1' w:bg2='light2' w:t2='dark2' w:accent1='accent1' w:accent2='accent2' w:accent3='accent3' w:accent4='accent4' w:accent5='accent5' w:accent6='accent6' w:hyperlink='hyperlink' w:followedHyperlink='followedHyperlink'/>
    <w:doNotIncludeSubdocsInStats/>
    <w:shapeDefaults>
        <o:shapedefaults v:ext='edit' spidmax='1186'/>
        <o:shapelayout v:ext='edit'>
            <o:idmap v:ext='edit' data='1'/>
        </o:shapelayout>
    </w:shapeDefaults>
    <w:decimalSymbol w:val='.'/>
    <w:listSeparator w:val=','/>
</w:settings>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/webSettings.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.webSettings+xml'>
<pkg:xmlData>
    <w:webSettings xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' mc:Ignorable='w14'>
    <w:optimizeForBrowser/>
    <w:relyOnVML/>
    <w:allowPNG/>
</w:webSettings>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/stylesWithEffects.xml' pkg:contentType='application/vnd.ms-word.stylesWithEffects+xml'>
<pkg:xmlData>
    <w:styles xmlns:wpc='http://schemas.microsoft.com/office/word/2010/wordprocessingCanvas' xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:o='urn:schemas-microsoft-com:office:office' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:m='http://schemas.openxmlformats.org/officeDocument/2006/math' xmlns:v='urn:schemas-microsoft-com:vml' xmlns:wp14='http://schemas.microsoft.com/office/word/2010/wordprocessingDrawing' xmlns:wp='http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing' xmlns:w10='urn:schemas-microsoft-com:office:word' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' xmlns:wpg='http://schemas.microsoft.com/office/word/2010/wordprocessingGroup' xmlns:wpi='http://schemas.microsoft.com/office/word/2010/wordprocessingInk' xmlns:wne='http://schemas.microsoft.com/office/word/2006/wordml' xmlns:wps='http://schemas.microsoft.com/office/word/2010/wordprocessingShape' mc:Ignorable='w14 wp14'>
    <w:docDefaults>
        <w:rPrDefault>
            <w:rPr>
                <w:rFonts w:asciiTheme='minorHAnsi' w:eastAsiaTheme='minorEastAsia' w:hAnsiTheme='minorHAnsi' w:cstheme='minorBidi'/>
                <w:sz w:val='22'/>
                <w:szCs w:val='22'/>
                <w:lang w:val='en-US' w:eastAsia='en-US' w:bidi='ar-SA'/>
            </w:rPr>
        </w:rPrDefault>
        <w:pPrDefault>
            <w:pPr>
                <w:spacing w:after='200' w:line='276' w:lineRule='auto'/>
            </w:pPr>
        </w:pPrDefault>
    </w:docDefaults>
    <w:latentStyles w:defLockedState='0' w:defUIPriority='99' w:defSemiHidden='1' w:defUnhideWhenUsed='1' w:defQFormat='0' w:count='267'>
        <w:lsdException w:name='Normal' w:semiHidden='0' w:uiPriority='0' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 1' w:semiHidden='0' w:uiPriority='9' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 2' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 3' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 4' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 5' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 6' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 7' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 8' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 9' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='toc 1' w:uiPriority='39'/>
        <w:lsdException w:name='toc 2' w:uiPriority='39'/>
        <w:lsdException w:name='toc 3' w:uiPriority='39'/>
        <w:lsdException w:name='toc 4' w:uiPriority='39'/>
        <w:lsdException w:name='toc 5' w:uiPriority='39'/>
        <w:lsdException w:name='toc 6' w:uiPriority='39'/>
        <w:lsdException w:name='toc 7' w:uiPriority='39'/>
        <w:lsdException w:name='toc 8' w:uiPriority='39'/>
        <w:lsdException w:name='toc 9' w:uiPriority='39'/>
        <w:lsdException w:name='caption' w:uiPriority='35' w:qFormat='1'/>
        <w:lsdException w:name='Title' w:semiHidden='0' w:uiPriority='10' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Default Paragraph Font' w:uiPriority='1'/>
        <w:lsdException w:name='Subtitle' w:semiHidden='0' w:uiPriority='11' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Strong' w:semiHidden='0' w:uiPriority='22' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Emphasis' w:semiHidden='0' w:uiPriority='20' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Table Grid' w:semiHidden='0' w:uiPriority='59' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Placeholder Text' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='No Spacing' w:semiHidden='0' w:uiPriority='1' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Light Shading' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 1' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 1' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 1' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 1' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 1' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 1' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Revision' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='List Paragraph' w:semiHidden='0' w:uiPriority='34' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Quote' w:semiHidden='0' w:uiPriority='29' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Intense Quote' w:semiHidden='0' w:uiPriority='30' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Medium List 2 Accent 1' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 1' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 1' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 1' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 1' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 1' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 1' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 1' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 2' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 2' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 2' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 2' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 2' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 2' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 2' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 2' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 2' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 2' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 2' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 2' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 2' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 2' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 3' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 3' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 3' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 3' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 3' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 3' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 3' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 3' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 3' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 3' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 3' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 3' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 3' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 3' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 4' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 4' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 4' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 4' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 4' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 4' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 4' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 4' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 4' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 4' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 4' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 4' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 4' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 4' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 5' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 5' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 5' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 5' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 5' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 5' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 5' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 5' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 5' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 5' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 5' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 5' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 5' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 5' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 6' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 6' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 6' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 6' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 6' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 6' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 6' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 6' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 6' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 6' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 6' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 6' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 6' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 6' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Subtle Emphasis' w:semiHidden='0' w:uiPriority='19' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Intense Emphasis' w:semiHidden='0' w:uiPriority='21' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Subtle Reference' w:semiHidden='0' w:uiPriority='31' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Intense Reference' w:semiHidden='0' w:uiPriority='32' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Book Title' w:semiHidden='0' w:uiPriority='33' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Bibliography' w:uiPriority='37'/>
        <w:lsdException w:name='TOC Heading' w:uiPriority='39' w:qFormat='1'/>
    </w:latentStyles>
    <w:style w:type='paragraph' w:default='1' w:styleId='Normal'>
        <w:name w:val='Normal'/>
        <w:qFormat/>
    </w:style>
    <w:style w:type='character' w:default='1' w:styleId='DefaultParagraphFont'>
        <w:name w:val='Default Paragraph Font'/>
        <w:uiPriority w:val='1'/>
        <w:semiHidden/>
        <w:unhideWhenUsed/>
    </w:style>
    <w:style w:type='table' w:default='1' w:styleId='TableNormal'>
        <w:name w:val='Normal Table'/>
        <w:uiPriority w:val='99'/>
        <w:semiHidden/>
        <w:unhideWhenUsed/>
        <w:tblPr>
            <w:tblInd w:w='0' w:type='dxa'/>
            <w:tblCellMar>
                <w:top w:w='0' w:type='dxa'/>
                <w:left w:w='108' w:type='dxa'/>
                <w:bottom w:w='0' w:type='dxa'/>
                <w:right w:w='108' w:type='dxa'/>
            </w:tblCellMar>
        </w:tblPr>
    </w:style>
    <w:style w:type='numbering' w:default='1' w:styleId='NoList'>
        <w:name w:val='No List'/>
        <w:uiPriority w:val='99'/>
        <w:semiHidden/>
        <w:unhideWhenUsed/>
    </w:style>
</w:styles>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/fontTable.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.fontTable+xml'>
<pkg:xmlData>
    <w:fonts xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' mc:Ignorable='w14'>
    <w:font w:name='Times New Roman'>
        <w:panose1 w:val='02020603050405020304'/>
        <w:charset w:val='00'/>
        <w:family w:val='roman'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='E0002EFF' w:usb1='C000785B' w:usb2='00000009' w:usb3='00000000' w:csb0='000001FF' w:csb1='00000000'/>
    </w:font>
    <w:font w:name='Arial'>
        <w:panose1 w:val='020B0604020202020204'/>
        <w:charset w:val='00'/>
        <w:family w:val='swiss'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='E0002EFF' w:usb1='C000785B' w:usb2='00000009' w:usb3='00000000' w:csb0='000001FF' w:csb1='00000000'/>
    </w:font>
    <w:font w:name='Calibri'>
        <w:panose1 w:val='020F0502020204030204'/>
        <w:charset w:val='00'/>
        <w:family w:val='swiss'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='E0002AFF' w:usb1='C000247B' w:usb2='00000009' w:usb3='00000000' w:csb0='000001FF' w:csb1='00000000'/>
    </w:font>
    <w:font w:name='Swis721 Ex BT'>
        <w:altName w:val='Sitka Small'/>
        <w:charset w:val='00'/>
        <w:family w:val='swiss'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='00000001' w:usb1='00000000' w:usb2='00000000' w:usb3='00000000' w:csb0='0000001B' w:csb1='00000000'/>
    </w:font>
    <w:font w:name='Wingdings 2'>
        <w:panose1 w:val='05020102010507070707'/>
        <w:charset w:val='02'/>
        <w:family w:val='roman'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='00000000' w:usb1='10000000' w:usb2='00000000' w:usb3='00000000' w:csb0='80000000' w:csb1='00000000'/>
    </w:font>
    <w:font w:name='Papyrus'>
        <w:panose1 w:val='03070502060502030205'/>
        <w:charset w:val='00'/>
        <w:family w:val='script'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='00000003' w:usb1='00000000' w:usb2='00000000' w:usb3='00000000' w:csb0='00000001' w:csb1='00000000'/>
    </w:font>
    <w:font w:name='Cambria'>
        <w:panose1 w:val='02040503050406030204'/>
        <w:charset w:val='00'/>
        <w:family w:val='roman'/>
        <w:pitch w:val='variable'/>
        <w:sig w:usb0='E00006FF' w:usb1='420024FF' w:usb2='02000000' w:usb3='00000000' w:csb0='0000019F' w:csb1='00000000'/>
    </w:font>
</w:fonts>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/docProps/core.xml' pkg:contentType='application/vnd.openxmlformats-package.core-properties+xml' pkg:padding='256'>
<pkg:xmlData>
    <cp:coreProperties xmlns:cp='http://schemas.openxmlformats.org/package/2006/metadata/core-properties' xmlns:dc='http://purl.org/dc/elements/1.1/' xmlns:dcterms='http://purl.org/dc/terms/' xmlns:dcmitype='http://purl.org/dc/dcmitype/' xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance'>
    <dc:title>Date</dc:title>
    <dc:creator>mark.silva</dc:creator>
    <cp:lastModifiedBy>Robert Frost</cp:lastModifiedBy>
    <cp:revision>2</cp:revision>
    <cp:lastPrinted>2011-04-04T22:40:00Z</cp:lastPrinted>
    <dcterms:created xsi:type='dcterms:W3CDTF'>2018-08-15T16:04:00Z</dcterms:created>
    <dcterms:modified xsi:type='dcterms:W3CDTF'>2018-08-15T16:04:00Z</dcterms:modified>
</cp:coreProperties>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/word/styles.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.wordprocessingml.styles+xml'>
<pkg:xmlData>
    <w:styles xmlns:mc='http://schemas.openxmlformats.org/markup-compatibility/2006' xmlns:r='http://schemas.openxmlformats.org/officeDocument/2006/relationships' xmlns:w='http://schemas.openxmlformats.org/wordprocessingml/2006/main' xmlns:w14='http://schemas.microsoft.com/office/word/2010/wordml' mc:Ignorable='w14'>
    <w:docDefaults>
        <w:rPrDefault>
            <w:rPr>
                <w:rFonts w:ascii='Times New Roman' w:eastAsia='Times New Roman' w:hAnsi='Times New Roman' w:cs='Times New Roman'/>
                <w:lang w:val='en-US' w:eastAsia='en-US' w:bidi='ar-SA'/>
            </w:rPr>
        </w:rPrDefault>
        <w:pPrDefault/>
    </w:docDefaults>
    <w:latentStyles w:defLockedState='0' w:defUIPriority='99' w:defSemiHidden='1' w:defUnhideWhenUsed='1' w:defQFormat='0' w:count='267'>
        <w:lsdException w:name='Normal' w:semiHidden='0' w:uiPriority='0' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 1' w:semiHidden='0' w:uiPriority='9' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 2' w:semiHidden='0' w:uiPriority='9' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 3' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 4' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 5' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 6' w:uiPriority='9' w:qFormat='1'/>
        <w:lsdException w:name='heading 7' w:semiHidden='0' w:uiPriority='9' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 8' w:semiHidden='0' w:uiPriority='9' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='heading 9' w:semiHidden='0' w:uiPriority='9' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='toc 1' w:uiPriority='39'/>
        <w:lsdException w:name='toc 2' w:uiPriority='39'/>
        <w:lsdException w:name='toc 3' w:uiPriority='39'/>
        <w:lsdException w:name='toc 4' w:uiPriority='39'/>
        <w:lsdException w:name='toc 5' w:uiPriority='39'/>
        <w:lsdException w:name='toc 6' w:uiPriority='39'/>
        <w:lsdException w:name='toc 7' w:uiPriority='39'/>
        <w:lsdException w:name='toc 8' w:uiPriority='39'/>
        <w:lsdException w:name='toc 9' w:uiPriority='39'/>
        <w:lsdException w:name='caption' w:uiPriority='35' w:qFormat='1'/>
        <w:lsdException w:name='Title' w:semiHidden='0' w:uiPriority='10' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Default Paragraph Font' w:uiPriority='1'/>
        <w:lsdException w:name='Subtitle' w:semiHidden='0' w:uiPriority='11' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Strong' w:semiHidden='0' w:uiPriority='22' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Emphasis' w:semiHidden='0' w:uiPriority='20' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Table Grid' w:semiHidden='0' w:uiPriority='59' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Placeholder Text' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='No Spacing' w:semiHidden='0' w:uiPriority='1' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Light Shading' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 1' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 1' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 1' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 1' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 1' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 1' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Revision' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='List Paragraph' w:semiHidden='0' w:uiPriority='34' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Quote' w:semiHidden='0' w:uiPriority='29' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Intense Quote' w:semiHidden='0' w:uiPriority='30' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Medium List 2 Accent 1' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 1' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 1' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 1' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 1' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 1' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 1' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 1' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 2' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 2' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 2' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 2' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 2' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 2' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 2' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 2' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 2' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 2' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 2' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 2' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 2' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 2' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 3' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 3' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 3' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 3' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 3' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 3' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 3' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 3' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 3' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 3' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 3' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 3' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 3' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 3' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 4' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 4' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 4' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 4' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 4' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 4' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 4' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 4' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 4' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 4' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 4' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 4' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 4' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 4' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 5' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 5' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 5' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 5' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 5' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 5' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 5' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 5' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 5' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 5' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 5' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 5' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 5' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 5' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Shading Accent 6' w:semiHidden='0' w:uiPriority='60' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light List Accent 6' w:semiHidden='0' w:uiPriority='61' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Light Grid Accent 6' w:semiHidden='0' w:uiPriority='62' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 1 Accent 6' w:semiHidden='0' w:uiPriority='63' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Shading 2 Accent 6' w:semiHidden='0' w:uiPriority='64' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 1 Accent 6' w:semiHidden='0' w:uiPriority='65' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium List 2 Accent 6' w:semiHidden='0' w:uiPriority='66' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 1 Accent 6' w:semiHidden='0' w:uiPriority='67' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 2 Accent 6' w:semiHidden='0' w:uiPriority='68' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Medium Grid 3 Accent 6' w:semiHidden='0' w:uiPriority='69' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Dark List Accent 6' w:semiHidden='0' w:uiPriority='70' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Shading Accent 6' w:semiHidden='0' w:uiPriority='71' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful List Accent 6' w:semiHidden='0' w:uiPriority='72' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Colorful Grid Accent 6' w:semiHidden='0' w:uiPriority='73' w:unhideWhenUsed='0'/>
        <w:lsdException w:name='Subtle Emphasis' w:semiHidden='0' w:uiPriority='19' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Intense Emphasis' w:semiHidden='0' w:uiPriority='21' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Subtle Reference' w:semiHidden='0' w:uiPriority='31' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Intense Reference' w:semiHidden='0' w:uiPriority='32' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Book Title' w:semiHidden='0' w:uiPriority='33' w:unhideWhenUsed='0' w:qFormat='1'/>
        <w:lsdException w:name='Bibliography' w:uiPriority='37'/>
        <w:lsdException w:name='TOC Heading' w:uiPriority='39' w:qFormat='1'/>
    </w:latentStyles>
    <w:style w:type='paragraph' w:default='1' w:styleId='Normal'>
        <w:name w:val='Normal'/>
        <w:qFormat/>
        <w:rPr>
            <w:sz w:val='24'/>
            <w:szCs w:val='24'/>
        </w:rPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='Heading2'>
        <w:name w:val='heading 2'/>
        <w:basedOn w:val='Normal'/>
        <w:next w:val='Normal'/>
        <w:qFormat/>
        <w:pPr>
            <w:keepNext/>
            <w:outlineLvl w:val='1'/>
        </w:pPr>
        <w:rPr>
            <w:b/>
            <w:szCs w:val='20'/>
            <w:u w:val='single'/>
        </w:rPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='Heading7'>
        <w:name w:val='heading 7'/>
        <w:basedOn w:val='Normal'/>
        <w:next w:val='Normal'/>
        <w:qFormat/>
        <w:pPr>
            <w:keepNext/>
            <w:jc w:val='center'/>
            <w:outlineLvl w:val='6'/>
        </w:pPr>
        <w:rPr>
            <w:rFonts w:ascii='Arial' w:hAnsi='Arial'/>
            <w:b/>
            <w:bCs/>
            <w:sz w:val='20'/>
            <w:szCs w:val='20'/>
        </w:rPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='Heading8'>
        <w:name w:val='heading 8'/>
        <w:basedOn w:val='Normal'/>
        <w:next w:val='Normal'/>
        <w:qFormat/>
        <w:pPr>
            <w:keepNext/>
            <w:jc w:val='center'/>
            <w:outlineLvl w:val='7'/>
        </w:pPr>
        <w:rPr>
            <w:szCs w:val='20'/>
        </w:rPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='Heading9'>
        <w:name w:val='heading 9'/>
        <w:basedOn w:val='Normal'/>
        <w:next w:val='Normal'/>
        <w:qFormat/>
        <w:pPr>
            <w:keepNext/>
            <w:jc w:val='both'/>
            <w:outlineLvl w:val='8'/>
        </w:pPr>
        <w:rPr>
            <w:szCs w:val='20'/>
        </w:rPr>
    </w:style>
    <w:style w:type='character' w:default='1' w:styleId='DefaultParagraphFont'>
        <w:name w:val='Default Paragraph Font'/>
        <w:uiPriority w:val='1'/>
        <w:semiHidden/>
        <w:unhideWhenUsed/>
    </w:style>
    <w:style w:type='table' w:default='1' w:styleId='TableNormal'>
        <w:name w:val='Normal Table'/>
        <w:uiPriority w:val='99'/>
        <w:semiHidden/>
        <w:unhideWhenUsed/>
        <w:tblPr>
            <w:tblInd w:w='0' w:type='dxa'/>
            <w:tblCellMar>
                <w:top w:w='0' w:type='dxa'/>
                <w:left w:w='108' w:type='dxa'/>
                <w:bottom w:w='0' w:type='dxa'/>
                <w:right w:w='108' w:type='dxa'/>
            </w:tblCellMar>
        </w:tblPr>
    </w:style>
    <w:style w:type='numbering' w:default='1' w:styleId='NoList'>
        <w:name w:val='No List'/>
        <w:uiPriority w:val='99'/>
        <w:semiHidden/>
        <w:unhideWhenUsed/>
    </w:style>
    <w:style w:type='paragraph' w:styleId='Header'>
        <w:name w:val='header'/>
        <w:basedOn w:val='Normal'/>
        <w:semiHidden/>
        <w:pPr>
            <w:tabs>
                <w:tab w:val='center' w:pos='4320'/>
                <w:tab w:val='right' w:pos='8640'/>
            </w:tabs>
        </w:pPr>
        <w:rPr>
            <w:sz w:val='20'/>
            <w:szCs w:val='20'/>
        </w:rPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='Footer'>
        <w:name w:val='footer'/>
        <w:basedOn w:val='Normal'/>
        <w:semiHidden/>
        <w:pPr>
            <w:tabs>
                <w:tab w:val='center' w:pos='4320'/>
                <w:tab w:val='right' w:pos='8640'/>
            </w:tabs>
        </w:pPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='NoSpacing'>
        <w:name w:val='No Spacing'/>
        <w:qFormat/>
        <w:rPr>
            <w:sz w:val='24'/>
            <w:szCs w:val='24'/>
        </w:rPr>
    </w:style>
    <w:style w:type='paragraph' w:styleId='BodyText'>
        <w:name w:val='Body Text'/>
        <w:basedOn w:val='Normal'/>
        <w:semiHidden/>
        <w:rPr>
            <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
            <w:sz w:val='20'/>
            <w:u w:val='single'/>
        </w:rPr>
    </w:style>
    <w:style w:type='character' w:customStyle='1' w:styleId='CharChar'>
        <w:name w:val='Char Char'/>
        <w:semiHidden/>
        <w:rPr>
            <w:rFonts w:ascii='Arial' w:hAnsi='Arial' w:cs='Arial'/>
            <w:szCs w:val='24'/>
            <w:u w:val='single'/>
        </w:rPr>
    </w:style>
</w:styles>
</pkg:xmlData>
</pkg:part>
<pkg:part pkg:name='/docProps/app.xml' pkg:contentType='application/vnd.openxmlformats-officedocument.extended-properties+xml' pkg:padding='256'>
<pkg:xmlData>
    <Properties xmlns='http://schemas.openxmlformats.org/officeDocument/2006/extended-properties' xmlns:vt='http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes'>
    <Template>Normal.dotm</Template>
    <TotalTime>0</TotalTime>
    <Pages>1</Pages>
    <Words>448</Words>
    <Characters>2559</Characters>
    <Application>Microsoft Office Word</Application>
    <DocSecurity>0</DocSecurity>
    <Lines>21</Lines>
    <Paragraphs>6</Paragraphs>
    <ScaleCrop>false</ScaleCrop>
    <HeadingPairs>
        <vt:vector size='2' baseType='variant'>
            <vt:variant>
                <vt:lpstr>Title</vt:lpstr>
            </vt:variant>
            <vt:variant>
                <vt:i4>1</vt:i4>
            </vt:variant>
        </vt:vector>
    </HeadingPairs>
    <TitlesOfParts>
        <vt:vector size='1' baseType='lpstr'>
            <vt:lpstr>Date</vt:lpstr>
        </vt:vector>
    </TitlesOfParts>
    <Company>CL&amp;E</Company>
    <LinksUpToDate>false</LinksUpToDate>
    <CharactersWithSpaces>3001</CharactersWithSpaces>
    <SharedDoc>false</SharedDoc>
    <HyperlinksChanged>false</HyperlinksChanged>
    <AppVersion>14.0000</AppVersion>
</Properties>
</pkg:xmlData>
</pkg:part>
</pkg:package>";

            //********** THIS IS THE MISSING AREA **********//


            int keyWidth = (Count < 10) ? pageWidthArr[Count] : pageWidthArr[10];

            //This string is for the page width
            columns = @"<w:tbl>
            <w:tblPr>
                <w:tblW w:w='pageWidth' w:type='pct'/>
                <w:tblInd w:w='-1072' w:type='dxa'/>
                <w:tblCellMar>
                    <w:left w:w='0' w:type='dxa'/>
                    <w:right w:w='0' w:type='dxa'/>
                </w:tblCellMar>
                <w:tblLook w:val='0000' w:firstRow='0' w:lastRow='0' w:firstColumn='0' w:lastColumn='0' w:noHBand='0' w:noVBand='0'/>
            </w:tblPr>
            <w:tblGrid>
                <w:gridCol w:w='3142'/>
                <w:gridCol w:w='1574'/>
            </w:tblGrid>" + columns;

            columns += "</w:tbl>";


            
            //********** THIS IS THE MISSING AREA **********//
            FullXml = Headermsc + header + columns +  windows + FooterMsc;

            if (Count <= 10)
            {
                FullXml = FullXml.Replace("pageWidth", pageWidthArr[Count -1].ToString());
                FullXml = FullXml.Replace("keyWidth", keyWidthArr[Count - 1].ToString());
                FullXml = FullXml.Replace("columnWidth", colWdithArr[Count - 1].ToString());
                FullXml = FullXml.Replace("KeyFontWeight", KeyFontWeight[Count - 1].ToString());
                FullXml = FullXml.Replace("ColumnFontWeight", ColumnFontWeight[Count - 1].ToString());
            }
            else
            {
                FullXml = FullXml.Replace("pageWidth", pageWidthArr[10].ToString());
                FullXml = FullXml.Replace("keyWidthPH", keyWidthArr[10].ToString());
                FullXml = FullXml.Replace("columnWidth", colWdithArr[10].ToString());
                FullXml = FullXml.Replace("KeyFontWeight", KeyFontWeight[Count - 1].ToString());
                FullXml = FullXml.Replace("ColumnFontWeight", ColumnFontWeight[Count - 1].ToString());

                
            }


            // Sets the font size for the main content cells
            if (Count > 10)
            {
                FullXml = FullXml.Replace("<w:sz w:val='20'/>", "<w:sz w:val='18'/>");

            }
            else if ((Count > 9))
            {
                FullXml = FullXml.Replace("<w:sz w:val='20'/>", "<w:sz w:val='16'/>");

            }
            else if (Count > 3)
            {
                FullXml = FullXml.Replace("<w:sz w:val='20'/>", "<w:sz w:val='18'/>");

            }

            FullXml = FullXml.Replace("(WALLTYPE)", "(" + CurrentColumnValues.WALLTYPE + ")");
            //            MainWindow.ErrorBanner.Text = "";


            try
            {
                if (FullXml != null)
                {
                    Datasheet.LoadXml(FullXml);
                    try
                    {
                        Datasheet.Save(@"C:\Users\" + Environment.UserName + @"\Downloads\" + HeaderGenerator.PROJECTNAME + " - Datasheet.doc");
                    }
                    catch (Exception)
                    {
                        MainWindow.AppWindow.ErrorBannerUpdater("Document open in another window, Please close it and try again.");
                    }
                }
                else
                {
//                    MainWindow.ErrorBanner.Text = "Nothing to generate. Please upload a file.";
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("---------- " + exception);
//                MainWindowErrorBanner.Text = "Document is already open. Please close it.";
            }




        }


    }
}