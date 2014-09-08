Module FlagCountry

    Public _prov As New ArrayList
    Public _proPic As New ArrayList


    Public Sub MakeDataBase()

        'ชื่อประเทศ
        '----------------    

        _prov.Add("United States".ToUpper)
        _prov.Add("Canada".ToUpper)
        _prov.Add("Afghanistan".ToUpper)
        _prov.Add("Albania".ToUpper)
        _prov.Add("Algeria".ToUpper)
        _prov.Add("Samoa".ToUpper)
        _prov.Add("Andorra".ToUpper)
        _prov.Add("Angola".ToUpper)
        _prov.Add("Anguilla".ToUpper)
        _prov.Add("Antarctica".ToUpper)
        _prov.Add("Antigua".ToUpper)
        _prov.Add("Argentina".ToUpper)
        _prov.Add("Armenia".ToUpper)
        _prov.Add("Aruba".ToUpper)
        _prov.Add("Australia".ToUpper)
        _prov.Add("Austria".ToUpper)
        _prov.Add("Azerbaijan".ToUpper)
        _prov.Add("Bahama".ToUpper)
        _prov.Add("Bahrain".ToUpper)
        _prov.Add("Bangladesh".ToUpper)
        _prov.Add("Barbados".ToUpper)
        _prov.Add("Belarus".ToUpper)
        _prov.Add("Belgium".ToUpper)
        _prov.Add("Belize".ToUpper)
        _prov.Add("Benin".ToUpper)
        _prov.Add("Bermuda".ToUpper)
        _prov.Add("Bhutan".ToUpper)
        _prov.Add("Bolivia".ToUpper)
        _prov.Add("Bosnia".ToUpper)
        _prov.Add("Botswana".ToUpper)
        _prov.Add("Bouvet".ToUpper)
        _prov.Add("Brazil".ToUpper)
        _prov.Add("Indian".ToUpper)
        _prov.Add("Virgin".ToUpper)
        _prov.Add("Brunei".ToUpper)
        _prov.Add("Bulgaria".ToUpper)
        _prov.Add("Burkina".ToUpper)
        _prov.Add("Burundi".ToUpper)
        _prov.Add("Cambodia".ToUpper)
        _prov.Add("Cameroon".ToUpper)
        _prov.Add("Cape Verde".ToUpper)
        _prov.Add("Cayman".ToUpper)
        _prov.Add("African".ToUpper)
        _prov.Add("Chad".ToUpper)
        _prov.Add("Chile".ToUpper)
        _prov.Add("China".ToUpper)
        _prov.Add("Christmas".ToUpper)
        _prov.Add("Cocos".ToUpper)
        _prov.Add("Colombia".ToUpper)
        _prov.Add("Comoros".ToUpper)
        _prov.Add("Congo".ToUpper)
        _prov.Add("Cook".ToUpper)
        _prov.Add("Costa".ToUpper)
        _prov.Add("Cote".ToUpper)
        _prov.Add("Croatia".ToUpper)
        _prov.Add("Cuba".ToUpper)
        _prov.Add("Cyprus".ToUpper)
        _prov.Add("Czech".ToUpper)
        _prov.Add("Denmark".ToUpper)
        _prov.Add("Djibouti".ToUpper)
        _prov.Add("Dominica".ToUpper)
        _prov.Add("Dominican".ToUpper)
        _prov.Add("Timor".ToUpper)
        _prov.Add("Ecuador".ToUpper)
        _prov.Add("Egypt".ToUpper)
        _prov.Add("Salvador".ToUpper)
        _prov.Add("Equatorial".ToUpper)
        _prov.Add("Eritrea".ToUpper)
        _prov.Add("Estonia".ToUpper)
        _prov.Add("Ethiopia".ToUpper)
        _prov.Add("Falkland".ToUpper)
        _prov.Add("Faroe Islands".ToUpper)
        _prov.Add("Fiji".ToUpper)
        _prov.Add("Finland".ToUpper)
        _prov.Add("France".ToUpper)
        _prov.Add("Metropolitan".ToUpper)
        _prov.Add("Guiana".ToUpper)
        _prov.Add("Polynesia".ToUpper)
        _prov.Add("Territories".ToUpper)
        _prov.Add("Gabon".ToUpper)
        _prov.Add("Gambia".ToUpper)
        _prov.Add("Georgia".ToUpper)
        _prov.Add("Germany".ToUpper)
        _prov.Add("Ghana".ToUpper)
        _prov.Add("Gibraltar".ToUpper)
        _prov.Add("Greece".ToUpper)
        _prov.Add("Greenland".ToUpper)
        _prov.Add("Grenada".ToUpper)
        _prov.Add("Guadeloupe".ToUpper)
        _prov.Add("Guam".ToUpper)
        _prov.Add("Guatemala".ToUpper)
        _prov.Add("Guinea".ToUpper)
        _prov.Add("Bissau".ToUpper)
        _prov.Add("Guyana".ToUpper)
        _prov.Add("Haiti".ToUpper)
        _prov.Add("Heard".ToUpper)
        _prov.Add("Honduras".ToUpper)
        _prov.Add("Hong Kong".ToUpper)
        _prov.Add("Hungary".ToUpper)
        _prov.Add("Iceland".ToUpper)
        _prov.Add("India".ToUpper)
        _prov.Add("Indonesia".ToUpper)
        _prov.Add("Iraq".ToUpper)
        _prov.Add("Ireland".ToUpper)
        _prov.Add("Iran".ToUpper)
        _prov.Add("Israel".ToUpper)
        _prov.Add("Italy".ToUpper)
        _prov.Add("Jamaica".ToUpper)
        _prov.Add("Japan".ToUpper)
        _prov.Add("Jordan".ToUpper)
        _prov.Add("Kazakhstan".ToUpper)
        _prov.Add("Kenya".ToUpper)
        _prov.Add("Kiribati".ToUpper)
        _prov.Add("South Korea".ToUpper)
        _prov.Add("North Korea".ToUpper)
        _prov.Add("Kuwait".ToUpper)
        _prov.Add("Kyrgyzstan".ToUpper)
        _prov.Add("Laos".ToUpper)
        _prov.Add("Latvia".ToUpper)
        _prov.Add("Lebanon".ToUpper)
        _prov.Add("Lesotho".ToUpper)
        _prov.Add("Liberia".ToUpper)
        _prov.Add("Libyan".ToUpper)
        _prov.Add("Liechtenstein".ToUpper)
        _prov.Add("Lithuania".ToUpper)
        _prov.Add("Luxembourg".ToUpper)
        _prov.Add("Macau".ToUpper)
        _prov.Add("Madagascar".ToUpper)
        _prov.Add("Malawi".ToUpper)
        _prov.Add("Malaysia".ToUpper)
        _prov.Add("Maldives".ToUpper)
        _prov.Add("Mali".ToUpper)
        _prov.Add("Malta".ToUpper)
        _prov.Add("Marshall".ToUpper)
        _prov.Add("Martinique".ToUpper)
        _prov.Add("Mauritania".ToUpper)
        _prov.Add("Mauritius".ToUpper)
        _prov.Add("Mayotte".ToUpper)
        _prov.Add("Mexico".ToUpper)
        _prov.Add("Micronesia".ToUpper)
        _prov.Add("Moldova".ToUpper)
        _prov.Add("Monaco".ToUpper)
        _prov.Add("Mongolia".ToUpper)
        _prov.Add("Monserrat".ToUpper)
        _prov.Add("Morocco".ToUpper)
        _prov.Add("Mozambique".ToUpper)
        _prov.Add("Myanmar".ToUpper)
        _prov.Add("Namibia".ToUpper)
        _prov.Add("Nauru".ToUpper)
        _prov.Add("Nepal".ToUpper)
        _prov.Add("Netherland".ToUpper)
        _prov.Add("Antilles".ToUpper)
        _prov.Add("Caledonia".ToUpper)
        _prov.Add("Zealand".ToUpper)
        _prov.Add("Nicaragua".ToUpper)
        _prov.Add("Niger".ToUpper)
        _prov.Add("Nigeria".ToUpper)
        _prov.Add("Niue".ToUpper)
        _prov.Add("Norfolk".ToUpper)
        _prov.Add("Mariana".ToUpper)
        _prov.Add("Norway".ToUpper)
        _prov.Add("Oman".ToUpper)
        _prov.Add("Pakistan".ToUpper)
        _prov.Add("Palau".ToUpper)
        _prov.Add("Panama".ToUpper)
        _prov.Add("Papua".ToUpper)
        _prov.Add("Paraguay".ToUpper)
        _prov.Add("Peru".ToUpper)
        _prov.Add("Philippine".ToUpper)
        _prov.Add("Pitcairn".ToUpper)
        _prov.Add("Poland".ToUpper)
        _prov.Add("Portugal".ToUpper)
        _prov.Add("Puerto".ToUpper)
        _prov.Add("Qatar".ToUpper)
        _prov.Add("Reunion".ToUpper)
        _prov.Add("Romania".ToUpper)
        _prov.Add("Russia".ToUpper)
        _prov.Add("Rwanda".ToUpper)
        _prov.Add("Saint".ToUpper)
        _prov.Add("Samoa".ToUpper)
        _prov.Add("Marino".ToUpper)
        _prov.Add("Tome".ToUpper)
        _prov.Add("Saudi".ToUpper)
        _prov.Add("Senegal".ToUpper)
        _prov.Add("Seychelles".ToUpper)
        _prov.Add("Sierra".ToUpper)
        _prov.Add("Singapore".ToUpper)
        _prov.Add("Slovakia".ToUpper)
        _prov.Add("Slovenia".ToUpper)
        _prov.Add("Solomon".ToUpper)
        _prov.Add("Somalia".ToUpper)
        _prov.Add("South Africa".ToUpper)
        _prov.Add("Spain".ToUpper)
        _prov.Add("Lanka".ToUpper)
        _prov.Add("Helena".ToUpper)
        _prov.Add("Kitts".ToUpper)
        _prov.Add("Pierre".ToUpper)
        _prov.Add("Vincent".ToUpper)
        _prov.Add("Sudan".ToUpper)
        _prov.Add("Suriname".ToUpper)
        _prov.Add("Svalbard".ToUpper)
        _prov.Add("Swaziland".ToUpper)
        _prov.Add("Sweden".ToUpper)
        _prov.Add("Switzerland".ToUpper)
        _prov.Add("Syria".ToUpper)
        _prov.Add("Taiwan".ToUpper)
        _prov.Add("Tajikistan".ToUpper)
        _prov.Add("Tanzania".ToUpper)
        _prov.Add("Thailand".ToUpper)
        _prov.Add("Togo".ToUpper)
        _prov.Add("Tokelau".ToUpper)
        _prov.Add("Tonga".ToUpper)
        _prov.Add("Trinidad".ToUpper)
        _prov.Add("Tunisia".ToUpper)
        _prov.Add("Turkey".ToUpper)
        _prov.Add("Turkmenistan".ToUpper)
        _prov.Add("Turks".ToUpper)
        _prov.Add("Tuvalu".ToUpper)
        _prov.Add("Uganda".ToUpper)
        _prov.Add("Ukraine".ToUpper)
        _prov.Add("Arab".ToUpper)
        _prov.Add("Kingdom".ToUpper)
        _prov.Add("Minor".ToUpper)
        _prov.Add("Virgin".ToUpper)
        _prov.Add("Uruguay".ToUpper)
        _prov.Add("Uzbekistan".ToUpper)
        _prov.Add("Vanuatu".ToUpper)
        _prov.Add("Vatican".ToUpper)
        _prov.Add("Venezuela".ToUpper)
        _prov.Add("VietNam".ToUpper)
        _prov.Add("Wallis".ToUpper)
        _prov.Add("Sahara".ToUpper)
        _prov.Add("Yemen".ToUpper)
        _prov.Add("Yugoslavia".ToUpper)
        _prov.Add("Zaire".ToUpper)
        _prov.Add("Zambia".ToUpper)
        _prov.Add("Zimbabwe".ToUpper)
        _prov.Add("UTAH")
        _prov.Add("Montenegro".ToUpper)
        _prov.Add("Yugoslavia".ToUpper)
        _prov.Add("Balkan".ToUpper)
        _prov.Add("Serbia".ToUpper) 'Fix new flag
        _prov.Add("Xizang".ToUpper) 'Fix new flag
        _prov.Add("-") 'Fix new flag

        'เกาะ/ทะเล ต่าง ๆ ทั่วโลก
        '----------------------
        'http://en.wikipedia.org/wiki/List_of_islands_by_area
        ' http://en.wikipedia.org/wiki/List_of_islands

        _prov.Add("Sumatara".ToUpper) 'indonesia
        _prov.Add("Sulawesi".ToUpper) 'indonesia

        _prov.Add("Sea".ToUpper)
        _prov.Add("Ocean".ToUpper)
        _prov.Add("Pacific".ToUpper)
        _prov.Add("Atlantic".ToUpper)
        _prov.Add("Indian".ToUpper)
        _prov.Add("Arctic".ToUpper)
        _prov.Add("อันดามัน".ToUpper)
        '
        '

        '_prov.Add("Guinea".ToUpper)  'indonesia
        '_prov.Add("Borneo".ToUpper) 'Brunei
        '_prov.Add("Baffin".ToUpper) 'Canada
        '_prov.Add("Honshu".ToUpper) 'japan
        '_prov.Add("Victoria".ToUpper) 'Canada
        '_prov.Add("Great".ToUpper) 'UK
        '_prov.Add("Ellesmere".ToUpper) 'canada
        '_prov.Add("Sulawesi".ToUpper) 'indonesia
        '_prov.Add("South Island".ToUpper) 'new zealand
        '_prov.Add("Java".ToUpper) 'indonesia
        '_prov.Add("North Island".ToUpper) 'new zealand
        '_prov.Add("Luzon".ToUpper) 'philipinese
        '_prov.Add("Newfoundland".ToUpper) 'canada
        '_prov.Add("Mindanao".ToUpper) 'phlip
        '_prov.Add("Hokkai".ToUpper) 'japan
        '_prov.Add("Hispaniola".ToUpper) 'Dominican Republic
        '_prov.Add("Sakhalin".ToUpper) 'Russia
        '_prov.Add("Banks".ToUpper) 'canada
        '_prov.Add("Tasmania".ToUpper) 'australia
        '_prov.Add("Devon".ToUpper) 'canada
        '_prov.Add("Alexander".ToUpper) 'NONE
        '_prov.Add("Tierra".ToUpper) 'Argentina 
        '_prov.Add("Severny".ToUpper) 'russia
        '_prov.Add("Berkner".ToUpper) 'none
        '_prov.Add("Heiberg".ToUpper) 'canada
        '_prov.Add("Melville".ToUpper) 'canada
        '_prov.Add("Southampton".ToUpper) 'canada
        '_prov.Add("Marajo".ToUpper) 'brazil
        '_prov.Add("Spitsbergen".ToUpper) 'norway
        '_prov.Add("Kyushu".ToUpper) 'japan
        '_prov.Add("New Britain".ToUpper) ' Papua New Guinea
        '_prov.Add("Prince".ToUpper) 'canada
        '_prov.Add("Yuzhny".ToUpper) 'russia
        '_prov.Add("Hainan".ToUpper) 'china
        '_prov.Add("Vancouver".ToUpper) 'canada
        '_prov.Add("Sicily".ToUpper) 'italy
        '_prov.Add("Somerset".ToUpper) 'canada
        '_prov.Add("Kotelny".ToUpper) 'russia
        '_prov.Add("Sardinia".ToUpper) 'italy
        '_prov.Add("Bananal".ToUpper) 'brazil
        '_prov.Add("Shikoku".ToUpper) 'japan
        '_prov.Add("Halmahera".ToUpper) 'indonesia
        '_prov.Add("Seram".ToUpper) 'indonesia
        '_prov.Add("Bathurst".ToUpper) 'canada
        '_prov.Add("Patrick".ToUpper) 'canada
        '_prov.Add("Thurston".ToUpper) 'NONE
        '_prov.Add("Nordaustlandet".ToUpper) 'norway
        '_prov.Add("Sumbawa".ToUpper) 'indonesia
        '_prov.Add("Revolution".ToUpper) 'russia
        '_prov.Add("Flores".ToUpper) 'indonesia
        '_prov.Add("William".ToUpper) 'canada
        '_prov.Add("Negros".ToUpper) 'philipinese
        '_prov.Add("Samar".ToUpper) 'philipinese
        '_prov.Add("Palawan".ToUpper) 'philipinese
        '_prov.Add("Panay".ToUpper) 'philipinese
        '_prov.Add("Tupinambarana".ToUpper) 'indonesia
        '_prov.Add("Sudarso".ToUpper) 'indonesia
        '_prov.Add("Bangka".ToUpper) 'indonesia
        '_prov.Add("Ringnes".ToUpper) 'canada
        '_prov.Add("Bolshevik".ToUpper) 'russia
        '_prov.Add("Bylot".ToUpper) 'canada
        '_prov.Add("Sumba".ToUpper) 'indonesia
        '_prov.Add("Mindoro".ToUpper) 'philipinese
        '_prov.Add("Viti".ToUpper) 'fiji
        '_prov.Add("Hawai".ToUpper) 'USA
        '_prov.Add("Breton".ToUpper) 'canada
        '_prov.Add("Bougainville".ToUpper) 'Papua New Guinea 
        '_prov.Add("Kodiak".ToUpper) 'USA
        '_prov.Add("Komsomolets".ToUpper) 'russia
        '_prov.Add("Corsica".ToUpper) 'France 
        '_prov.Add("Qeqertarsuaq".ToUpper) 'greenland
        '_prov.Add("Carney".ToUpper) 'Antarctica
        '_prov.Add("Buru".ToUpper) 'indonesia
        '_prov.Add("Crete".ToUpper) 'Greece 
        '_prov.Add("Anticosti".ToUpper) 'canada
        '_prov.Add("Roosevelt".ToUpper) 'new zealand
        '_prov.Add("Wrangel".ToUpper) 'russia
        '_prov.Add("Leyte".ToUpper) 'philipinese
        '_prov.Add("Zealand".ToUpper) 'denmark
        '_prov.Add("Cornwallis".ToUpper) 'canada
        '_prov.Add("Graham".ToUpper) 'canada
        '_prov.Add("Siberia".ToUpper) 'russia
        '_prov.Add("Melville".ToUpper) 'australia
        '_prov.Add("Vanua".ToUpper) 'fiji
        '_prov.Add("Wellington".ToUpper) 'Chile
        '_prov.Add("Bali".ToUpper) 'indonesia
        '_prov.Add("Chichagof".ToUpper) 'USA
        '_prov.Add("Guadalcanal".ToUpper) 'solomon
        '_prov.Add("Amund".ToUpper)
        '_prov.Add("Lyakhovsky".ToUpper) ' russia
        '_prov.Add("".ToUpper)
        '_prov.Add("".ToUpper)
     

        'เพื่อนบ้าน
        _prov.Add("แม่")
        _prov.Add("พรมแดน")
        _prov.Add("พม่า")
        _prov.Add("ลาว")
        _prov.Add("กัมพูชา")
        _prov.Add("จีน")


        'ในประเทศ
        _prov.Add("เชียงราย")
        _prov.Add("เชียงใหม่")
        _prov.Add("น่าน")
        _prov.Add("พะเยา")
        _prov.Add("แพร่")
        _prov.Add("แม่ฮ่องสอน")
        _prov.Add("ลำปาง")
        _prov.Add("ลำพูน")
        _prov.Add("อุตรดิตถ์")
        _prov.Add("กาฬสินธุ์")
        _prov.Add("ขอนแก่น")
        _prov.Add("ชัยภูมิ")
        _prov.Add("นครพนม")
        _prov.Add("นครราชสีมา")
        _prov.Add("บึงกาฬ")
        _prov.Add("บุรีรัมย์")
        _prov.Add("มหาสารคาม")
        _prov.Add("มุกดาหาร")
        _prov.Add("ยโสธร")
        _prov.Add("ร้อยเอ็ด")
        _prov.Add("เลย")
        _prov.Add("สกลนคร")
        _prov.Add("สุรินทร์")
        _prov.Add("ศรีสะเกษ")
        _prov.Add("หนองคาย")
        _prov.Add("หนองบัวลำภู")
        _prov.Add("อุดรธานี")
        _prov.Add("อุบลราชธานี")
        _prov.Add("อำนาจเจริญ")
        _prov.Add("กรุงเทพมหานคร ")
        _prov.Add("กำแพงเพชร")
        _prov.Add("ชัยนาท")
        _prov.Add("นครนายก")
        _prov.Add("นครปฐม")
        _prov.Add("นครสวรรค์")
        _prov.Add("นนทบุรี")
        _prov.Add("ปทุมธานี")
        _prov.Add("พระนครศรีอยุธยา")
        _prov.Add("พิจิตร")
        _prov.Add("พิษณุโลก")
        _prov.Add("เพชรบูรณ์")
        _prov.Add("ลพบุรี")
        _prov.Add("สมุทรปราการ")
        _prov.Add("สมุทรสงคราม")
        _prov.Add("สมุทรสาคร")
        _prov.Add("สิงห์บุรี")
        _prov.Add("สุโขทัย")
        _prov.Add("สุพรรณบุรี")
        _prov.Add("สระบุรี")
        _prov.Add("อ่างทอง")
        _prov.Add("อุทัยธานี")
        _prov.Add("จันทบุรี")
        _prov.Add("ฉะเชิงเทรา")
        _prov.Add("ชลบุรี")
        _prov.Add("ตราด")
        _prov.Add("ปราจีนบุรี")
        _prov.Add("ระยอง")
        _prov.Add("สระแก้ว")
        _prov.Add("กาญจนบุรี")
        _prov.Add("ตาก")
        _prov.Add("ประจวบคีรีขันธ์")
        _prov.Add("เพชรบุรี")
        _prov.Add("ราชบุรี")
        _prov.Add("กระบี่")
        _prov.Add("ชุมพร")
        _prov.Add("ตรัง")
        _prov.Add("นครศรีธรรมราช")
        _prov.Add("นราธิวาส")
        _prov.Add("ปัตตานี")
        _prov.Add("พังงา")
        _prov.Add("พัทลุง")
        _prov.Add("ภูเก็ต")
        _prov.Add("ระนอง")
        _prov.Add("สตูล")
        _prov.Add("สงขลา")
        _prov.Add("สุราษฎร์ธานี")
        _prov.Add("ยะลา")


        'Fix จังหวัดในไทย






        'Fix for USGS (จังหวัดใน USA)
        '-----------------------



        '########################################################################


        'ไอคอนประเทศ
        '-----------------


        _proPic.Add(My.Resources.us)
        _proPic.Add(My.Resources.ca)
        _proPic.Add(My.Resources.af)
        _proPic.Add(My.Resources.al)
        _proPic.Add(My.Resources.dz)
        _proPic.Add(My.Resources.ASS)
        _proPic.Add(My.Resources.ad)
        _proPic.Add(My.Resources.ao)
        _proPic.Add(My.Resources.ai)
        _proPic.Add(My.Resources.ag)
        _proPic.Add(My.Resources.ag)
        _proPic.Add(My.Resources.ar)
        _proPic.Add(My.Resources.am)
        _proPic.Add(My.Resources.aw)
        _proPic.Add(My.Resources.au)
        _proPic.Add(My.Resources.at)
        _proPic.Add(My.Resources.az)
        _proPic.Add(My.Resources.bs)
        _proPic.Add(My.Resources.bh)
        _proPic.Add(My.Resources.bd)
        _proPic.Add(My.Resources.bb)
        _proPic.Add(My.Resources.by)
        _proPic.Add(My.Resources.be)
        _proPic.Add(My.Resources.bz)
        _proPic.Add(My.Resources.bj)
        _proPic.Add(My.Resources.bm)
        _proPic.Add(My.Resources.bt)
        _proPic.Add(My.Resources.bo)
        _proPic.Add(My.Resources.ba)
        _proPic.Add(My.Resources.bw)
        _proPic.Add(My.Resources.bv)
        _proPic.Add(My.Resources.br)
        _proPic.Add(My.Resources.io)
        _proPic.Add(My.Resources.vg)
        _proPic.Add(My.Resources.bn)
        _proPic.Add(My.Resources.bg)
        _proPic.Add(My.Resources.bf)
        _proPic.Add(My.Resources.bi)
        _proPic.Add(My.Resources.kh)
        _proPic.Add(My.Resources.cm)
        _proPic.Add(My.Resources.cv)
        _proPic.Add(My.Resources.ky)
        _proPic.Add(My.Resources.cf)
        _proPic.Add(My.Resources.td)
        _proPic.Add(My.Resources.cl)
        _proPic.Add(My.Resources.cn)
        _proPic.Add(My.Resources.cx)
        _proPic.Add(My.Resources.cc)
        _proPic.Add(My.Resources.co)
        _proPic.Add(My.Resources.km)
        _proPic.Add(My.Resources.cg)
        _proPic.Add(My.Resources.ck)
        _proPic.Add(My.Resources.cr)
        _proPic.Add(My.Resources.ci)
        _proPic.Add(My.Resources.hr)
        _proPic.Add(My.Resources.cu)
        _proPic.Add(My.Resources.cy)
        _proPic.Add(My.Resources.cz)
        _proPic.Add(My.Resources.dk)
        _proPic.Add(My.Resources.dj)
        _proPic.Add(My.Resources.dm)
        _proPic.Add(My.Resources._do)
        _proPic.Add(My.Resources.tp)
        _proPic.Add(My.Resources.ec)
        _proPic.Add(My.Resources.eg)
        _proPic.Add(My.Resources.sv)
        _proPic.Add(My.Resources.gq)
        _proPic.Add(My.Resources.er)
        _proPic.Add(My.Resources.ee)
        _proPic.Add(My.Resources.et)
        _proPic.Add(My.Resources.fk)
        _proPic.Add(My.Resources.fo)
        _proPic.Add(My.Resources.fj)
        _proPic.Add(My.Resources.fi)
        _proPic.Add(My.Resources.fr)
        _proPic.Add(My.Resources.fx)
        _proPic.Add(My.Resources.gf)
        _proPic.Add(My.Resources.pf)
        _proPic.Add(My.Resources.tf)
        _proPic.Add(My.Resources.ga)
        _proPic.Add(My.Resources.gm)
        _proPic.Add(My.Resources.ge)
        _proPic.Add(My.Resources.de)
        _proPic.Add(My.Resources.gh)
        _proPic.Add(My.Resources.gi)
        _proPic.Add(My.Resources.gr)
        _proPic.Add(My.Resources.gl)
        _proPic.Add(My.Resources.gd)
        _proPic.Add(My.Resources.gp)
        _proPic.Add(My.Resources.gu)
        _proPic.Add(My.Resources.gt)
        _proPic.Add(My.Resources.gn)
        _proPic.Add(My.Resources.gw)
        _proPic.Add(My.Resources.gy)
        _proPic.Add(My.Resources.ht)
        _proPic.Add(My.Resources.hm)
        _proPic.Add(My.Resources.hn)
        _proPic.Add(My.Resources.hk)
        _proPic.Add(My.Resources.hu)
        _proPic.Add(My.Resources._is)
        _proPic.Add(My.Resources._in)
        _proPic.Add(My.Resources.id)
        _proPic.Add(My.Resources.iq)
        _proPic.Add(My.Resources.ie)
        _proPic.Add(My.Resources.ir)
        _proPic.Add(My.Resources.il)
        _proPic.Add(My.Resources.it)
        _proPic.Add(My.Resources.jm)
        _proPic.Add(My.Resources.jp)
        _proPic.Add(My.Resources.jo)
        _proPic.Add(My.Resources.kz)
        _proPic.Add(My.Resources.ke)
        _proPic.Add(My.Resources.ki)
        _proPic.Add(My.Resources.kr)
        _proPic.Add(My.Resources.North_Korea_Flag_16)
        _proPic.Add(My.Resources.kw)
        _proPic.Add(My.Resources.kg)
        _proPic.Add(My.Resources.la)
        _proPic.Add(My.Resources.lv)
        _proPic.Add(My.Resources.lb)
        _proPic.Add(My.Resources.ls)
        _proPic.Add(My.Resources.lr)
        _proPic.Add(My.Resources.ly)
        _proPic.Add(My.Resources.li)
        _proPic.Add(My.Resources.lt)
        _proPic.Add(My.Resources.lu)
        _proPic.Add(My.Resources.mo)
        _proPic.Add(My.Resources.mg)
        _proPic.Add(My.Resources.mw)
        _proPic.Add(My.Resources.my)
        _proPic.Add(My.Resources.mv)
        _proPic.Add(My.Resources.ml)
        _proPic.Add(My.Resources.mt)
        _proPic.Add(My.Resources.mh)
        _proPic.Add(My.Resources.mq)
        _proPic.Add(My.Resources.mr)
        _proPic.Add(My.Resources.mu)
        _proPic.Add(My.Resources.yt)
        _proPic.Add(My.Resources.mx)
        _proPic.Add(My.Resources.fm)
        _proPic.Add(My.Resources.md)
        _proPic.Add(My.Resources.mc)
        _proPic.Add(My.Resources.mn)
        _proPic.Add(My.Resources.ms)
        _proPic.Add(My.Resources.ma)
        _proPic.Add(My.Resources.mz)
        _proPic.Add(My.Resources.mm)
        _proPic.Add(My.Resources.na)
        _proPic.Add(My.Resources.nr)
        _proPic.Add(My.Resources.np)
        _proPic.Add(My.Resources.nl)
        _proPic.Add(My.Resources.an)
        _proPic.Add(My.Resources.nc)
        _proPic.Add(My.Resources.nz)
        _proPic.Add(My.Resources.ni)
        _proPic.Add(My.Resources.ne)
        _proPic.Add(My.Resources.ng)
        _proPic.Add(My.Resources.nu)
        _proPic.Add(My.Resources.nf)
        _proPic.Add(My.Resources.mp)
        _proPic.Add(My.Resources.no)
        _proPic.Add(My.Resources.om)
        _proPic.Add(My.Resources.pk)
        _proPic.Add(My.Resources.pw)
        _proPic.Add(My.Resources.pa)
        _proPic.Add(My.Resources.pg)
        _proPic.Add(My.Resources.py)
        _proPic.Add(My.Resources.pe)
        _proPic.Add(My.Resources.ph)
        _proPic.Add(My.Resources.pn)
        _proPic.Add(My.Resources.pl)
        _proPic.Add(My.Resources.pt)
        _proPic.Add(My.Resources.pr)
        _proPic.Add(My.Resources.qa)
        _proPic.Add(My.Resources.re)
        _proPic.Add(My.Resources.ro)
        _proPic.Add(My.Resources.ru)
        _proPic.Add(My.Resources.rw)
        _proPic.Add(My.Resources.lc)
        _proPic.Add(My.Resources.ws)
        _proPic.Add(My.Resources.sm)
        _proPic.Add(My.Resources.st)
        _proPic.Add(My.Resources.sa)
        _proPic.Add(My.Resources.sn)
        _proPic.Add(My.Resources.sc)
        _proPic.Add(My.Resources.sl)
        _proPic.Add(My.Resources.sg)
        _proPic.Add(My.Resources.sk)
        _proPic.Add(My.Resources.si)
        _proPic.Add(My.Resources.sb)
        _proPic.Add(My.Resources.so)
        _proPic.Add(My.Resources.za)
        _proPic.Add(My.Resources.es)
        _proPic.Add(My.Resources.lk)
        _proPic.Add(My.Resources.sh)
        _proPic.Add(My.Resources.kn)
        _proPic.Add(My.Resources.pm)
        _proPic.Add(My.Resources.vc)
        _proPic.Add(My.Resources.sd)
        _proPic.Add(My.Resources.sr)
        _proPic.Add(My.Resources.sj)
        _proPic.Add(My.Resources.sz)
        _proPic.Add(My.Resources.se)
        _proPic.Add(My.Resources.ch)
        _proPic.Add(My.Resources.sy)
        _proPic.Add(My.Resources.tw)
        _proPic.Add(My.Resources.tj)
        _proPic.Add(My.Resources.tz)
        _proPic.Add(My.Resources.th)
        _proPic.Add(My.Resources.tg)
        _proPic.Add(My.Resources.tk)
        _proPic.Add(My.Resources._to)
        _proPic.Add(My.Resources.tt)
        _proPic.Add(My.Resources.tn)
        _proPic.Add(My.Resources.tr)
        _proPic.Add(My.Resources.tm)
        _proPic.Add(My.Resources.tc)
        _proPic.Add(My.Resources.tv)
        _proPic.Add(My.Resources.ug)
        _proPic.Add(My.Resources.ua)
        _proPic.Add(My.Resources.ae)
        _proPic.Add(My.Resources.gb)
        _proPic.Add(My.Resources.um)
        _proPic.Add(My.Resources.vi)
        _proPic.Add(My.Resources.uy)
        _proPic.Add(My.Resources.uz)
        _proPic.Add(My.Resources.vu)
        _proPic.Add(My.Resources.va)
        _proPic.Add(My.Resources.ve)
        _proPic.Add(My.Resources.vn)
        _proPic.Add(My.Resources.wf)
        _proPic.Add(My.Resources.eh)
        _proPic.Add(My.Resources.ye)
        _proPic.Add(My.Resources.yu)
        _proPic.Add(My.Resources.earth)
        _proPic.Add(My.Resources.zm)
        _proPic.Add(My.Resources.zw)
        _proPic.Add(My.Resources.uh)
        _proPic.Add(My.Resources.mon)
        _proPic.Add(My.Resources.yugo)
        _proPic.Add(My.Resources.yugo)
        _proPic.Add(My.Resources.Serbia_Flag_16)
        _proPic.Add(My.Resources.cn)
        _proPic.Add(My.Resources.united_nations)


        'เกาะ/ทะเล ต่าง ๆ ทั่วโลก
        '----------------------
        _proPic.Add(My.Resources.id)
        _proPic.Add(My.Resources.id)

        _proPic.Add(My.Resources.earth) 'sea
        _proPic.Add(My.Resources.earth)
        _proPic.Add(My.Resources.earth)
        _proPic.Add(My.Resources.earth)
        _proPic.Add(My.Resources.earth)
        _proPic.Add(My.Resources.earth)
        _proPic.Add(My.Resources.earth)


        'แม่ Fix
        _proPic.Add(My.Resources.th)
        'เพื่อนบ้าน

        _proPic.Add(My.Resources.united_nations)
        _proPic.Add(My.Resources.mm)
        _proPic.Add(My.Resources.la)
        _proPic.Add(My.Resources.kh)
        _proPic.Add(My.Resources.ch)
        


        'ในประเทศ
        For d = 1 To 76
            _proPic.Add(My.Resources.th)
        Next

       

        'Fix for USGS
        '-----------------------

    End Sub

    Public Sub United_States()
        _proPic.Add(My.Resources.us)
    End Sub


End Module
