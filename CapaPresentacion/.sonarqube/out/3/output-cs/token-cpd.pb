¨
qC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Alumnos\Modificar_Alumno.cs
	namespace 	
CapaPresentacion
 
. 
Inscripcion &
{ 
public 

partial 
class 
Modificar_Alumno )
:* +
Form, 0
{ 
public 
Modificar_Alumno 
(  
)  !
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
iconButton1_Click &
(& '
object' -
sender. 4
,4 5
	EventArgs6 ?
e@ A
)A B
{ 	
E_Alumno 
alumno 
= 
new !
E_Alumno" *
(* +
)+ ,
;, -
alumno 
= 
L_Alumno 
. 
	Instancia '
.' (
listar_alumno_dni( 9
(9 :
dni_txt: A
.A B
TextB F
)F G
;G H
if 
( 
alumno 
!= 
null 
) 
{ 
Alumn_nombre 
. 
Text !
=" #
alumno$ *
.* +
Alumn_nombre+ 7
;7 8
Alumn_Direccion 
.  
Text  $
=% &
alumno' -
.- .
Alumn_Direccion. =
;= >

Correo_txt 
. 
Text 
=  !
alumno" (
.( )
Alum_Correo) 4
;4 5
telefono_txt   
.   
Text   !
=  " #
alumno  $ *
.  * +
Alum_Telefono  + 8
;  8 9
}!! 
}"" 	
private$$ 
void$$ 
iconButton2_Click$$ &
($$& '
object$$' -
sender$$. 4
,$$4 5
	EventArgs$$6 ?
e$$@ A
)$$A B
{%% 	
E_Alumno&& 
alumno&& 
=&& 
new&& !
E_Alumno&&" *
(&&* +
)&&+ ,
;&&, -
alumno'' 
.'' 
	Alumn_dni'' 
='' 
dni_txt'' &
.''& '
Text''' +
;''+ ,
alumno(( 
.(( 
Alumn_Direccion(( "
=((# $
Alumn_Direccion((% 4
.((4 5
Text((5 9
;((9 :
alumno)) 
.)) 
Alum_Correo)) 
=))  

Correo_txt))! +
.))+ ,
Text)), 0
;))0 1
alumno** 
.** 
Alum_Telefono**  
=**! "
telefono_txt**# /
.**/ 0
Text**0 4
;**4 5
if++ 
(++ 
L_Alumno++ 
.++ 
	Instancia++ "
.++" #
modificar_alumno++# 3
(++3 4
alumno++4 :
)++: ;
)++; <

MessageBox,, 
.,, 
Show,, 
(,,  
$str,,  *
),,* +
;,,+ ,
else-- 

MessageBox.. 
... 
Show.. 
(..  
$str..  ,
).., -
;..- .
}00 	
private22 
void22 
button1_Click22 "
(22" #
object22# )
sender22* 0
,220 1
	EventArgs222 ;
e22< =
)22= >
{33 	
this44 
.44 
Hide44 
(44 
)44 
;44 
M_alumno55 
alumno55 
=55 
new55 !
M_alumno55# +
(55+ ,
)55, -
;55- .
alumno66 
.66 
Show66 
(66 
)66 
;66 
}77 	
}88 
}99 ”
iC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Alumnos\M_alumno.cs
	namespace 	
CapaPresentacion
 
. 
Alumnos "
{ 
public 

partial 
class 
M_alumno !
:" #
Form$ (
{ 
public 
M_alumno 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
CrearButton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
Registro_Alumno 
registro_Alumno +
=, -
new. 1
Registro_Alumno2 A
(A B
)B C
;C D
registro_Alumno 
. 
Show  
(  !
)! "
;" #
} 	
private 
void 
ListarButton3_Click (
(( )
object) /
sender0 6
,6 7
	EventArgs8 A
eB C
)C D
{ 	
this 
. 
Hide 
( 
) 
; 
ListarAlumnos 
listarAlumnos '
=( )
new* -
ListarAlumnos. ;
(; <
)< =
;= >
listarAlumnos   
.   
Show   
(   
)    
;    !
}!! 	
private## 
void## 
EditarButton2_Click## (
(##( )
object##) /
sender##0 6
,##6 7
	EventArgs##8 A
e##B C
)##C D
{$$ 	
this%% 
.%% 
Hide%% 
(%% 
)%% 
;%% 
Modificar_Alumno&& 
modificar_Alumno&& -
=&&. /
new&&0 3
Modificar_Alumno&&4 D
(&&D E
)&&E F
;&&F G
modificar_Alumno'' 
.'' 
Show'' !
(''! "
)''" #
;''# $
}(( 	
private** 
void** 
Atrasbutton1_Click** '
(**' (
object**( .
sender**/ 5
,**5 6
	EventArgs**7 @
e**A B
)**B C
{++ 	
this,, 
.,, 
Hide,, 
(,, 
),, 
;,, 
MenuPrincipal-- 
menuPrincipal-- '
=--( )
new--* -
MenuPrincipal--. ;
(--; <
)--< =
;--= >
menuPrincipal.. 
... 
Show.. 
(.. 
)..  
;..  !
}// 	
}00 
}11 ¥
rC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\becas\Becas_Por_Exelencia.cs
	namespace 	
CapaPresentacion
 
{ 
public 

partial 
class 
Becas_Por_Exelencia ,
:- .
Form/ 3
{ 
public 
Becas_Por_Exelencia "
(" #
)# $
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Buscarbutton1_Click (
(( )
object) /
sender0 6
,6 7
	EventArgs8 A
eB C
)C D
{ 	
E_Alumno 
aux 
= 
CL_BecaExcelencia ,
., -
	Instancia- 6
.6 7$
Mostrar_Alumno_Exelencia7 O
(O P
DNItextBox1P [
.[ \
Text\ `
)` a
;a b
dataGridView1 
. 
Rows 
. 
Add "
(" #
aux# &
.& '
Alumn_nombre' 3
,3 4
aux4 7
.7 8!
Alumn_ApellidoPaterno8 M
,M N
auxN Q
.Q R!
Alumn_ApellidoMaternoR g
)g h
;h i
} 	
private 
void 
AtrasButton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
Becas_principal   
main    
=  ! "
new  # &
Becas_principal  ' 6
(  6 7
)  7 8
;  8 9
main!! 
.!! 
Show!! 
(!! 
)!! 
;!! 
}"" 	
}$$ 
}%% „
nC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Alumnos\ListarAlumnos.cs
	namespace 	
CapaPresentacion
 
{ 
public 

partial 
class 
ListarAlumnos &
:' (
Form) -
{ 
public 
ListarAlumnos 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
pictureBox1_Click &
(& '
object' -
sender. 4
,4 5
	EventArgs6 ?
e@ A
)A B
{ 	
} 	
private 
void #
DNItextBox1_TextChanged ,
(, -
object- 3
sender4 :
,: ;
	EventArgs< E
eF G
)G H
{ 	
} 	
private!! 
void!! 
Buscarbutton1_Click!! (
(!!( )
object!!) /
sender!!0 6
,!!6 7
	EventArgs!!8 A
e!!B C
)!!C D
{"" 	
string## 
aux## 
=## 
DNItextBox1## $
.##$ %
Text##% )
;##) *
if$$ 
($$ 
aux$$ 
!=$$ 
$str$$ 
)$$ 
{%% 
dataGridView1&& 
.&& 
Rows&& "
.&&" #
Clear&&# (
(&&( )
)&&) *
;&&* +
E_Alumno'' 
alumno'' 
=''  !
new''" %
E_Alumno''& .
(''. /
)''/ 0
;''0 1
if(( 
((( 
L_Alumno(( 
.(( 
	Instancia(( &
.((& '
listar_alumno_dni((' 8
(((8 9
aux((9 <
)((< =
!=((> @
null((A E
)((E F
alumno)) 
=)) 
L_Alumno)) %
.))% &
	Instancia))& /
.))/ 0
listar_alumno_dni))0 A
())A B
aux))B E
)))E F
;))F G
if++ 
(++ 
alumno++ 
!=++ 
null++ !
)++" #
{,, 
dataGridView1// !
.//! "
Rows//" &
.//& '
Add//' *
(//* +
alumno//+ 1
.//1 2
Alumn_nombre//2 >
,//> ?
alumno//? E
.//E F!
Alumn_ApellidoPaterno//F [
,//[ \
alumno//\ b
.//b c!
Alumn_ApellidoMaterno//c x
,//x y
alumno//y 
.	// Ä
	Alumn_dni
//Ä â
,
//â ä
alumno
//ä ê
.
//ê ë
Alum_Correo
//ë ú
,
//ú ù
alumno
//ù £
.
//£ §
Alumn_Fechnaci
//§ ≤
,
//≤ ≥
alumno
//≥ π
.
//π ∫
Alumn_Estado
//∫ ∆
)
//∆ «
;
//« »
}00 
}11 
}22 	
private44 
void44 
Atrasbutton1_Click44 '
(44' (
object44( .
sender44/ 5
,445 6
	EventArgs447 @
e44A B
)44B C
{55 	
this66 
.66 
Hide66 
(66 
)66 
;66 
M_alumno77 
alum77 
=77 
new77 
M_alumno77  (
(77( )
)77) *
;77* +
alum88 
.88 
Show88 
(88 
)88 
;88 
}99 	
}:: 
};; õB
pC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Alumnos\Registro Alumno.cs
	namespace 	
CapaPresentacion
 
{ 
public 

partial 
class 
Registro_Alumno (
:) *
Form+ /
{ 
public 
Registro_Alumno 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
panel1 
. 
Enabled 
= 
false "
;" #
} 	
private 
void 
pictureBox1_Click &
(& '
object' -
sender. 4
,4 5
	EventArgs6 ?
e@ A
)A B
{ 	
} 	
private 
void 
Salitbutton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{   	
this!! 
.!! 
Hide!! 
(!! 
)!! 
;!! 
M_alumno"" 
alumno"" 
="" 
new"" !
M_alumno""" *
(""* +
)""+ ,
;"", -
alumno## 
.## 
Show## 
(## 
)## 
;## 
}$$ 	
private&& 
void&& 
button1_Click&& "
(&&" #
object&&# )
sender&&* 0
,&&0 1
	EventArgs&&2 ;
e&&< =
)&&= >
{'' 	
string(( 
dn1i(( 
=(( 
DNItextBox1(( %
.((% &
Text((& *
;((* +
if)) 
()) 
L_Alumno)) 
.)) 
	Instancia)) "
.))" #'
verificar_existencia_alumno))# >
())> ?
dn1i))? C
)))C D
)))D E
{** 
this++ 
.++ 
Hide++ 
(++ 
)++ 
;++ 
Modificar_Alumno,,  
ma,,! #
=,,$ %
new,,& )
Modificar_Alumno,,* :
(,,: ;
),,; <
;,,< =
ma.. 
... 
Show.. 
(.. 
).. 
;.. 
}// 
else00 
panel100 
.00 
Enabled00 
=00  !
true00" &
;00& '
}22 	
private44 
void44 
button2_Click44 "
(44" #
object44# )
sender44* 0
,440 1
	EventArgs442 ;
e44< =
)44= >
{55 	
string66 
nombre66 
=66 
NombretextBox166 *
.66* +
Text66+ /
;66/ 0
string77 
apellido_paterno77 #
=77$ %
ApePaternotextBox177& 8
.778 9
Text779 =
;77= >
string88 
apellido_materno88 #
=88$ %
ApeMaternotextBox188& 8
.888 9
Text889 =
;88= >
string99 

dirreccion99 
=99 
DirecciontextBox199  1
.991 2
Text992 6
;996 7
DateTime:: 
fecha_nacimiento:: %
=::& '
DateTime::( 0
.::0 1
Parse::1 6
(::6 7$
fechaNacidateTimePicker1::7 O
.::O P
Text::P T
)::T U
;::U V
string;; 
nivel_educativo;; "
=;;# $
NivelEducativo_txt;;% 7
.;;7 8
Text;;8 <
;;;< =
string<< 
dni<< 
=<< 
DNItextBox1<< $
.<<$ %
Text<<% )
;<<) *
string== 
correo== 
=== 
CorreotextBox1== *
.==* +
Text==+ /
;==/ 0
string>> 
telefono>> 
=>> 
TelefonotextBox1>> .
.>>. /
Text>>/ 3
;>>3 4
float?? 
pension?? 
=?? 
float?? !
.??! "
Parse??" '
(??' (
Pension_txt??( 3
.??3 4
Text??4 8
)??8 9
;??9 :
string@@ 
nombre_apoderado@@ #
=@@$ % 
nomApoderadotextBox1@@& :
.@@: ;
Text@@; ?
;@@? @
stringAA &
apellido_paterno_apoderadoAA -
=AA. /&
apPaternoApoderadotextBox1AA0 J
.AAJ K
TextAAK O
;AAO P
stringBB &
apellido_materno_apoderadoBB -
=BB. /'
ApeMaternoApoderadotextBox1BB0 K
.BBK L
TextBBL P
;BBP Q
stringCC 
estadoCC 
=CC 
EstadotextBox1CC *
.CC* +
TextCC+ /
;CC/ 0
ifDD 
(DD 
nombreDD 
!=DD 
$strDD 
&&DD  
apellido_paternoDD! 1
!=DD2 4
$strDD5 8
&&DD9 ;
apellido_maternoDD< L
!=DDM O
$strDDP R
&&DDS U
dniDDV Y
!=DDZ \
$strDD] `
)DD` a
{EE 
ifFF 
(FF 
dniFF 
.FF 
LengthFF 
==FF !
$numFF" #
)FF# $
{GG 
varHH 
esnumeroHH  
=HH! "
intHH# &
.HH& '
TryParseHH' /
(HH/ 0
dniHH0 3
,HH3 4
outHH5 8
intHH9 <
nHH= >
)HH> ?
;HH? @
ifII 
(II 
esnumeroII  
==II! #
trueII$ (
)II( )
{JJ 
E_AlumnoKK  
alumnoKK! '
=KK( )
newKK* -
E_AlumnoKK. 6
(KK6 7
)KK7 8
;KK8 9
alumnoLL 
.LL 
Alumn_nombreLL +
=LL, -
nombreLL. 4
;LL4 5
alumnoMM 
.MM !
Alumn_ApellidoMaternoMM 4
=MM5 6
apellido_maternoMM7 G
;MMG H
alumnoNN 
.NN !
Alumn_ApellidoPaternoNN 4
=NN5 6
apellido_paternoNN7 G
;NNG H
alumnoOO 
.OO 
Alumn_DireccionOO .
=OO/ 0

dirreccionOO1 ;
;OO; <
alumnoPP 
.PP 
Alumn_FechnaciPP -
=PP. /
fecha_nacimientoPP0 @
;PP@ A
alumnoQQ 
.QQ 
	Alumn_dniQQ (
=QQ) *
dniQQ+ .
;QQ. /
alumnoRR 
.RR 
Alum_NivelEducativoRR 2
=RR3 4
nivel_educativoRR5 D
;RRD E
alumnoSS 
.SS 
Alum_CorreoSS *
=SS+ ,
correoSS- 3
;SS3 4
alumnoTT 
.TT 
Alumn_PensionTT ,
=TT- .
pensionTT/ 6
;TT6 7
alumnoUU 
.UU 
Alum_TelefonoUU ,
=UU- .
telefonoUU/ 7
;UU7 8
alumnoVV 
.VV !
Alumn_ApoderadoNombreVV 4
=VV5 6
nombre_apoderadoVV7 G
;VVG H
alumnoWW 
.WW #
Alumn_ApoderadoApellidoWW 6
=WW7 8&
apellido_paterno_apoderadoWW9 S
;WWS T
alumnoXX 
.XX "
Alumn_ApoderadoMaternoXX 5
=XX6 7&
apellido_materno_apoderadoXX8 R
;XXR S
alumnoYY 
.YY 
Alumn_EstadoYY +
=YY, -
estadoYY. 4
;YY4 5
alumnoZZ 
.ZZ !
Alumn_fechInscripcionZZ 4
=ZZ5 6
DateTimeZZ7 ?
.ZZ? @
ParseZZ@ E
(ZZE F
Fecha_inscripcionZZF W
.ZZW X
TextZZX \
)ZZ\ ]
;ZZ] ^
if[[ 
([[ 
L_Alumno[[ $
.[[$ %
	Instancia[[% .
.[[. /
crear_alumno[[/ ;
([[; <
alumno[[< B
)[[B C
)[[C D

MessageBox\\ &
.\\& '
Show\\' +
(\\+ ,
$str\\, ?
)\\? @
;\\@ A
else]] 

MessageBox^^ &
.^^& '
Show^^' +
(^^+ ,
$str^^, B
,^^B C
$str^^D K
)^^K L
;^^L M
}__ 
}`` 
}aa 
elsebb 

MessageBoxcc 
.cc 
Showcc 
(cc  
$strcc  .
,cc. /
$strcc0 7
)cc7 8
;cc8 9
}dd 	
}ee 
}ff ÿ
nC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\becas\Becas_principal.cs
	namespace 	
CapaPresentacion
 
. 
becas  
{ 
public 

partial 
class 
Becas_principal (
:) *
Form+ /
{ 
public 
Becas_principal 
( 
)  
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
button1_Click "
(" #
object# )
sender* 0
,0 1
	EventArgs2 ;
e< =
)= >
{ 	
this 
. 
Hide 
( 
) 
; 

Crear_beca 
crear 
= 
new "

Crear_beca# -
(- .
). /
;/ 0
crear 
. 
Show 
( 
) 
; 
} 	
private 
void 
button2_Click "
(" #
object# )
sender* 0
,0 1
	EventArgs2 ;
e< =
)= >
{ 	
this 
. 
Hide 
( 
) 
; 
Becas_Por_Exelencia 
listar  &
=' (
new) ,
Becas_Por_Exelencia- @
(@ A
)A B
;B C
listar   
.   
Show   
(   
)   
;   
}!! 	
private## 
void## 
button3_Click## "
(##" #
object### )
sender##* 0
,##0 1
	EventArgs##2 ;
e##< =
)##= >
{$$ 	
this%% 
.%% 
Hide%% 
(%% 
)%% 
;%% 
MenuPrincipal&& 
	principal&& #
=&&$ %
new&&& )
MenuPrincipal&&* 7
(&&7 8
)&&8 9
;&&9 :
	principal'' 
.'' 
Show'' 
('' 
)'' 
;'' 
}(( 	
})) 
}** µ-
iC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\becas\Crear_beca.cs
	namespace 	
CapaPresentacion
 
. 
becas  
{ 
public 

partial 
class 

Crear_beca #
:$ %
Form& *
{ 
public 

Crear_beca 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
panel1 
. 
Enabled 
= 
false "
;" #
} 	
private 
void 
iconButton1_Click &
(& '
object' -
sender. 4
,4 5
	EventArgs6 ?
e@ A
)A B
{ 	
string 
dni 
= 
dni_text !
.! "
Text" &
;& '
if 
( 
L_Alumno 
. 
	Instancia "
." #'
verificar_existencia_alumno# >
(> ?
dni? B
)B C
&&D F
CL_BecaExcelenciaG X
.X Y
	InstanciaY b
.b c!
verificar_Alumno_Becac x
(x y
dniy |
)| }
==	~ Ä
false
Å Ü
)
Ü á
{ 
panel1 
. 
Enabled 
=  
true! %
;% &
E_Alumno   
alumno   
=    !
L_Alumno  " *
.  * +
	Instancia  + 4
.  4 5
listar_alumno_dni  5 F
(  F G
dni  G J
)  J K
;  K L

Nombre_txt!! 
.!! 
Enabled!! "
=!!# $
false!!% *
;!!* +

Nombre_txt"" 
."" 
Text"" 
=""  !
alumno""" (
.""( )
Alumn_nombre"") 5
;""5 6 
Apellido_materno_txt## $
.##$ %
Enabled##% ,
=##- .
false##/ 4
;##4 5 
Apellido_materno_txt$$ $
.$$$ %
Text$$% )
=$$* +
alumno$$, 2
.$$2 3!
Alumn_ApellidoMaterno$$3 H
;$$H I 
Apellido_paterno_txt%% $
.%%$ %
Enabled%%% ,
=%%- .
false%%/ 4
;%%4 5 
Apellido_paterno_txt&& $
.&&$ %
Text&&% )
=&&* +
alumno&&, 2
.&&2 3!
Alumn_ApellidoPaterno&&3 H
;&&H I
E_Calificaciones''  
calificacion''! -
=''. /
CL_calificaciones''0 A
.''A B
	Instancia''B K
.''K L&
mostrar_calificaciones_dni''L f
(''f g
dni''g j
)''j k
;''k l
Promedio_txt(( 
.(( 
Enabled(( $
=((% &
false((' ,
;((, -
Promedio_txt)) 
.)) 
Text)) !
=))" #
calificacion))$ 0
.))0 1
Califi_Promedio))1 @
.))@ A
ToString))A I
())I J
)))J K
;))K L
}** 
else++ 

MessageBox,, 
.,, 
Show,, 
(,,  
$str,,  L
),,L M
;,,M N
}-- 	
private.. 
void.. 
reiniciar_texto.. $
(..$ %
)..% &
{// 	
panel100 
.00 
Enabled00 
=00 
false00 "
;00" #
dni_text11 
.11 
Text11 
=11 
$str11 
;11  

Nombre_txt22 
.22 
Text22 
=22 
$str22 !
;22! " 
Apellido_materno_txt33  
.33  !
Text33! %
=33& '
$str33( +
;33+ , 
Apellido_paterno_txt44  
.44  !
Text44! %
=44& '
$str44( +
;44+ ,
Promedio_txt55 
.55 
Text55 
=55 
$str55  #
;55# $
}88 	
private99 
void99 
iconButton2_Click99 &
(99& '
object99' -
sender99. 4
,994 5
	EventArgs996 ?
e99@ A
)99A B
{:: 	
string;; 
dni;; 
=;; 
dni_text;; !
.;;! "
Text;;" &
;;;& '
E_Alumno<< 
ea<< 
=<< 
new<< 
E_Alumno<< &
(<<& '
)<<' (
;<<( )
ea== 
.== 
	Alumn_dni== 
=== 
dni== 
;== 
if>> 
(>> 
CL_BecaExcelencia>> !
.>>! "
	Instancia>>" +
.>>+ ,
Beca_exelencia>>, :
(>>: ;
ea>>; =
)>>= >
)>>> ?

MessageBox>>@ J
.>>J K
Show>>K O
(>>O P
$str>>P d
)>>d e
;>>e f
else?? 

MessageBox?? 
.?? 
Show??  
(??  !
$str??! 5
)??5 6
;??6 7
reiniciar_texto@@ 
(@@ 
)@@ 
;@@ 
}BB 	
privateDD 
voidDD 
iconButton3_ClickDD &
(DD& '
objectDD' -
senderDD. 4
,DD4 5
	EventArgsDD6 ?
eDD@ A
)DDA B
{EE 	
thisFF 
.FF 
HideFF 
(FF 
)FF 
;FF 
Becas_principalGG 
mainGG  
=GG! "
newGG# &
Becas_principalGG' 6
(GG6 7
)GG7 8
;GG8 9
mainHH 
.HH 
ShowHH 
(HH 
)HH 
;HH 
}II 	
}JJ 
}KK 
}C:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Calificaciones\Listar_Calificaciones.cs
	namespace 	
CapaPresentacion
 
. 
InterfacesGraficas -
{ 
public 

partial 
class !
Listar_Calificaciones .
:/ 0
Form1 5
{ 
public !
Listar_Calificaciones $
($ %
)% &
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Buscarbutton1_Click (
(( )
object) /
sender0 6
,6 7
	EventArgs8 A
eB C
)C D
{ 	
E_Calificaciones 
aux  
=! "
CL_calificaciones# 4
.4 5
	Instancia5 >
.> ?&
mostrar_calificaciones_dni? Y
(Y Z
dni_txtZ a
.a b
Textb f
)f g
;g h!
ProfesordataGridView1 !
.! "
Rows" &
.& '
Add' *
(* +
aux+ .
.. /
Curso_id/ 7
,7 8
aux9 <
.< =
Califi_Promedio= L
,L M
auxN Q
.Q R
Califi_Parcial1R a
,a b
auxc f
.f g
Califi_Parcial2g v
,v w
auxx {
.{ |
Califi_Trabajos	| ã
,
ã å
aux
ç ê
.
ê ë
Califi_Final
ë ù
)
ù û
;
û ü
} 	
private 
void 
Salirbutton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
M_Calificaciones 
calificacion )
=* +
new, /
M_Calificaciones0 @
(@ A
)A B
;B C
calificacion   
.   
Show   
(   
)   
;    
}!! 	
}"" 
}## …?
ÄC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Calificaciones\Modificar_Calificaciones.cs
	namespace 	
CapaPresentacion
 
. 
Calificaciones )
{ 
public 

partial 
class $
Modificar_Calificaciones 1
:2 3
Form4 8
{ 
public $
Modificar_Calificaciones '
(' (
)( )
{ 	
InitializeComponent 
(  
)  !
;! "
panel1 
. 
Enabled 
= 
false "
;" #
} 	
private 
void 
Salirbutton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
M_Calificaciones 
calificacion )
=* +
new, /
M_Calificaciones0 @
(@ A
)A B
;B C
calificacion 
. 
Show 
( 
) 
;  
} 	
private!! 
void!! 
button1_Click!! "
(!!" #
object!!# )
sender!!* 0
,!!0 1
	EventArgs!!2 ;
e!!< =
)!!= >
{"" 	
string## 
dni## 
=## 
DNI_TXT##  
.##  !
Text##! %
;##% &
if$$ 
($$ 
L_Alumno$$ 
.$$ 
	Instancia$$ "
.$$" #'
verificar_existencia_alumno$$# >
($$> ?
dni$$? B
)$$B C
)$$C D
{%% 
panel1&& 
.&& 
Enabled&& 
=&&  
true&&! %
;&&% &
E_Calificaciones''  
califi''! '
=''( )
CL_calificaciones''* ;
.''; <
	Instancia''< E
.''E F&
mostrar_calificaciones_dni''F `
(''` a
dni''a d
)''d e
;''e f
if(( 
((( 
califi(( 
!=(( 
null(( "
)((" #
{)) 
Parcial1textBox2** $
.**$ %
Text**% )
=*** +
califi**, 2
.**2 3
Califi_Parcial1**3 B
.**B C
ToString**C K
(**K L
)**L M
;**M N
Parcial2textBox3++ $
.++$ %
Text++% )
=++* +
califi++, 2
.++2 3
Califi_Parcial2++3 B
.++B C
ToString++C K
(++K L
)++L M
;++M N
},, 
}.. 
else// 

MessageBox00 
.00 
Show00 
(00  
$str00  5
)005 6
;006 7
}11 	
private22 
void22 
Reset22 
(22 
)22 
{33 	
panel144 
.44 
Enabled44 
=44 
false44 "
;44" #
DNI_TXT55 
.55 
Text55 
=55 
$str55 
;55 
Parcial1textBox266 
.66 
Text66 !
=66" #
$str66$ &
;66& '
Parcial2textBox377 
.77 
Text77 !
=77" #
$str77$ &
;77& '
TrabajostextBox488 
.88 
Text88 !
=88" #
$str88$ &
;88& '
ExaFinaltextBox599 
.99 
Text99 !
=99" #
$str99$ &
;99& '
PromediotextBox1:: 
.:: 
Text:: !
=::" #
$str::$ &
;::& '
}<< 	
private== 
void== #
Continuarrbutton1_Click== ,
(==, -
object==- 3
sender==4 :
,==: ;
	EventArgs==< E
e==F G
)==G H
{>> 	
string?? 
dni?? 
=?? 
DNI_TXT??  
.??  !
Text??! %
;??% &
E_Calificaciones@@ 
califi@@ #
=@@$ %
new@@& )
E_Calificaciones@@* :
(@@: ;
)@@; <
;@@< =
califiAA 
.AA 
Califi_Parcial1AA "
=AA# $
intAA% (
.AA( )
ParseAA) .
(AA. /
Parcial1textBox2AA/ ?
.AA? @
TextAA@ D
)AAD E
;AAE F
califiBB 
.BB 
Califi_Parcial2BB "
=BB# $
intBB% (
.BB( )
ParseBB) .
(BB. /
Parcial2textBox3BB/ ?
.BB? @
TextBB@ D
)BBD E
;BBE F
ifCC 
(CC 
CL_calificacionesCC !
.CC! "
	InstanciaCC" +
.CC+ ,+
modificar_calificacion_parcial1CC, K
(CCK L
califiCCL R
,CCR S
dniCCT W
)CCW X
&&CCY [
CL_calificacionesCC\ m
.CCm n
	InstanciaCCn w
.CCw x-
 modificar_calificacion_parcial12	CCx ò
(
CCò ô
califi
CCô ü
,
CCü †
dni
CC° §
)
CC§ •
)
CC• ¶
{DD 
E_CalificacionesEE  
auxiliarEE! )
=EE* +
CL_calificacionesEE, =
.EE= >
	InstanciaEE> G
.EEG H&
mostrar_calificaciones_dniEEH b
(EEb c
dniEEc f
)EEf g
;EEg h
auxiliarFF 
.FF 
Califi_Parcial1FF (
=FF) *
intFF+ .
.FF. /
ParseFF/ 4
(FF4 5
Parcial1textBox2FF5 E
.FFE F
TextFFF J
)FFJ K
;FFK L
auxiliarGG 
.GG 
Califi_Parcial2GG (
=GG) *
intGG+ .
.GG. /
ParseGG/ 4
(GG4 5
Parcial2textBox3GG5 E
.GGE F
TextGGF J
)GGJ K
;GGK L
intHH 
promedioHH 
=HH 
(HH  
auxiliarHH  (
.HH( )
Califi_Parcial1HH) 8
+HH8 9
auxiliarHH9 A
.HHA B
Califi_Parcial2HHB Q
+HHQ R
auxiliarHHR Z
.HHZ [
Califi_FinalHH[ g
+HHg h
auxiliarHHh p
.HHp q
Califi_Promedio	HHq Ä
)
HHÄ Å
/
HHÇ É
$num
HHÑ Ö
;
HHÖ Ü
ifII 
(II 
auxiliarII 
.II 
Califi_PromedioII +
>II+ ,
$numII, .
)II. /
ifJJ 
(JJ 
CL_BecaExcelenciaJJ (
.JJ( )
	InstanciaJJ) 2
.JJ2 3!
verificar_Alumno_BecaJJ3 H
(JJH I
dniJJI L
)JJL M
)JJM N
ifKK 
(KK 
promedioKK #
<KK$ %
$numKK% '
)KK' (
ifLL 
(LL 
CL_calificacionesLL 0
.LL0 1
	InstanciaLL1 :
.LL: ;
modificar_BecaLL; I
(LLI J
dniLLJ M
)LLM N
)LLN O

MessageBoxMM  *
.MM* +
ShowMM+ /
(MM/ 0
$strMM0 b
)MMb c
;MMc d
ifOO 
(OO 
CL_calificacionesOO $
.OO$ %
	InstanciaOO% .
.OO. /+
modificar_calificacion_PromedioOO/ N
(OON O
auxiliarOOO W
,OOW X
dniOOX [
)OO[ \
)OO\ ]
{PP 
auxiliarQQ 
.QQ 
Califi_PromedioQQ ,
=QQ- .
promedioQQ/ 7
;QQ7 8

MessageBoxRR 
.RR 
ShowRR #
(RR# $
$strRR$ N
+RRO P
promedioRRQ Y
.RRY Z
ToStringRRZ b
(RRb c
)RRc d
)RRd e
;RRe f
}SS 
}TT 
elseUU 

MessageBoxVV 
.VV 
ShowVV 
(VV  
$strVV  ;
)VV; <
;VV< =
ResetXX 
(XX 
)XX 
;XX 
}[[ 	
}\\ 
}]] Ë
xC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Calificaciones\M_Calificaciones.cs
	namespace 	
CapaPresentacion
 
. 
Calificaciones )
{ 
public 

partial 
class 
M_Calificaciones )
:* +
Form, 0
{ 
public 
M_Calificaciones 
(  
)  !
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
Atrasbutton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
MenuPrincipal 
	principal #
=$ %
new& )
MenuPrincipal* 7
(7 8
)8 9
;9 :
	principal 
. 
Show 
( 
) 
; 
} 	
private 
void "
Registrarbutton1_Click +
(+ ,
object, 2
sender3 9
,9 :
	EventArgs; D
eE F
)F G
{ 	
this 
. 
Hide 
( 
) 
; #
Registro_Calificaciones #
registro$ ,
=- .
new/ 2#
Registro_Calificaciones3 J
(J K
)K L
;L M
registro 
. 
Show 
( 
) 
; 
}   	
private"" 
void"" "
Modificarbutton1_Click"" +
(""+ ,
object"", 2
sender""3 9
,""9 :
	EventArgs""; D
e""E F
)""F G
{## 	
this$$ 
.$$ 
Hide$$ 
($$ 
)$$ 
;$$ $
Modificar_Calificaciones%% $
mc%%% '
=%%( )
new%%* -$
Modificar_Calificaciones%%. F
(%%F G
)%%G H
;%%H I
mc&& 
.&& 
Show&& 
(&& 
)&& 
;&& 
}'' 	
private)) 
void)) 
Listarbutton1_Click)) (
())( )
object))) /
sender))0 6
,))6 7
	EventArgs))8 A
e))B C
)))C D
{** 	
this++ 
.++ 
Hide++ 
(++ 
)++ 
;++ !
Listar_Calificaciones,, !
lc,," $
=,,% &
new,,' *!
Listar_Calificaciones,,+ @
(,,@ A
),,A B
;,,B C
lc-- 
.-- 
Show-- 
(-- 
)-- 
;-- 
}.. 	
}// 
}00 ﬂ4
C:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Calificaciones\Registro_Calificaciones.cs
	namespace 	
CapaPresentacion
 
. 
InterfacesGraficas -
{ 
public 

partial 
class #
Registro_Calificaciones 0
:1 2
Form3 7
{ 
public #
Registro_Calificaciones &
(& '
)' (
{ 	
InitializeComponent 
(  
)  !
;! "
panel1 
. 
Enabled 
= 
false "
;" #
} 	
private 
void 
AtrasButton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
M_Calificaciones 
menuPrincipal *
=+ ,
new- 0
M_Calificaciones1 A
(A B
)B C
;C D
menuPrincipal 
. 
Show 
( 
)  
;  !
} 	
private   
void   
	reiniciar   
(   
)    
{!! 	
DNI_TXT"" 
."" 
Text"" 
="" 
$str"" 
;"" 
TrabajostextBox4## 
.## 
Text## !
=##" #
$str##$ &
;##& '
Parcial1textBox2$$ 
.$$ 
Text$$ !
=$$" #
$str$$$ &
;$$& '
Parcial2textBox3%% 
.%% 
Text%% !
=%%" #
$str%%$ &
;%%& '
ExaFinaltextBox5&& 
.&& 
Text&& !
=&&" #
$str&&$ &
;&&& '
PromediotextBox1'' 
.'' 
Text'' !
=''" #
$str''$ &
;''& '
panel1(( 
.(( 
Enabled(( 
=(( 
false(( "
;((" #
})) 	
private** 
void** 
Salirbutton1_Click** '
(**' (
object**( .
sender**/ 5
,**5 6
	EventArgs**7 @
e**A B
)**B C
{++ 	
string,, 
dni,, 
=,, 
DNI_TXT,,  
.,,  !
Text,,! %
;,,% &
PromediotextBox1-- 
.-- 
Enabled-- $
=--% &
false--' ,
;--, -
int// 
trabajos_aux// 
=// 
int// "
.//" #
Parse//# (
(//( )
TrabajostextBox4//) 9
.//9 :
Text//: >
)//> ?
;//? @
int00 
parcial1_aux00 
=00 
int00 "
.00" #
Parse00# (
(00( )
Parcial1textBox200) 9
.009 :
Text00: >
)00> ?
;00? @
int11 
parcial2_aux11 
=11 
int11 "
.11" #
Parse11# (
(11( )
Parcial2textBox311) 9
.119 :
Text11: >
)11> ?
;11? @
int22 
	final_aix22 
=22 
int22 
.22  
Parse22  %
(22% &
ExaFinaltextBox522& 6
.226 7
Text227 ;
)22; <
;22< =
float33 
suma33 
=33 
(33 
trabajos_aux33 &
+33' (
parcial1_aux33) 5
+336 7
parcial2_aux338 D
+33E F
	final_aix33G P
)33P Q
/33R S
$num33T U
;33U V
int44 
promedio44 
=44 
(44 
int44 
)44  
(44  !
suma44! %
)44% &
;44& '
PromediotextBox155 
.55 
Text55 !
=55" #
promedio55$ ,
.55, -
ToString55- 5
(555 6
)556 7
;557 8
E_Calificaciones77 
aux77  
=77! "
new77# &
E_Calificaciones77' 7
(777 8
)778 9
;779 :
aux88 
.88 
Califi_Trabajos88 
=88  !
int88" %
.88% &
Parse88& +
(88+ ,
TrabajostextBox488, <
.88< =
Text88= A
)88A B
;88B C
aux99 
.99 
Califi_Parcial199 
=99  !
int99" %
.99% &
Parse99& +
(99+ ,
Parcial1textBox299, <
.99< =
Text99= A
)99A B
;99B C
aux:: 
.:: 
Califi_Parcial2:: 
=::  !
int::" %
.::% &
Parse::& +
(::+ ,
Parcial2textBox3::, <
.::< =
Text::= A
)::A B
;::B C
aux;; 
.;; 
Califi_Final;; 
=;;  !
int;;" %
.;;% &
Parse;;& +
(;;+ ,
ExaFinaltextBox5;;, <
.;;< =
Text;;= A
);;A B
;;;B C
aux<< 
.<< 
Califi_Promedio<< 
=<<  !
int<<" %
.<<% &
Parse<<& +
(<<+ ,
PromediotextBox1<<, <
.<<< =
Text<<= A
)<<A B
;<<B C
if== 
(== 
CL_calificaciones== !
.==! "
	Instancia==" +
.==+ , 
crear_calificaciones==, @
(==@ A
aux==A D
,==D E
dni==F I
)==I J
)==J K

MessageBox>> 
.>> 
Show>> 
(>>  
$str>>  6
)>>6 7
;>>7 8
else?? 

MessageBox@@ 
.@@ 
Show@@ 
(@@  
$str@@  0
)@@0 1
;@@1 2
}AA 	
privateCC 
voidCC 
button1_ClickCC "
(CC" #
objectCC# )
senderCC* 0
,CC0 1
	EventArgsCC2 ;
eCC< =
)CC= >
{DD 	
stringEE 
dniEE 
=EE 
DNI_TXTEE  
.EE  !
TextEE! %
;EE% &
ifFF 
(FF 
L_AlumnoFF 
.FF 
	InstanciaFF "
.FF" #'
verificar_existencia_alumnoFF# >
(FF> ?
dniFF? B
)FFB C
)FFC D
panel1GG 
.GG 
EnabledGG 
=GG  
trueGG! %
;GG% &
elseHH 

MessageBoxII 
.II 
ShowII 
(II  
$strII  5
)II5 6
;II6 7
}JJ 	
}KK 
}LL ∂
kC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Curso\Listar_Curso.cs
	namespace 	
CapaPresentacion
 
. 
InterfacesGraficas -
{ 
public 

partial 
class 
Listar_Curso %
:& '
Form( ,
{ 
public 
Listar_Curso 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
} 
} ˆ
fC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Curso\M_Curso.cs
	namespace 	
CapaPresentacion
 
. 
Curso  
{ 
public 

partial 
class 
M_Curso  
:! "
Form# '
{ 
public 
M_Curso 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void !
Regresarbutton1_Click *
(* +
object+ 1
sender2 8
,8 9
	EventArgs: C
eD E
)E F
{ 	
this 
. 
Hide 
( 
) 
; 
MenuPrincipal 
menuPrincipal '
=( )
new* -
MenuPrincipal. ;
(; <
)< =
;= >
menuPrincipal 
. 
Show 
( 
)  
;  !
} 	
private 
void 
Listarbutton1_Click (
(( )
object) /
sender0 6
,6 7
	EventArgs8 A
eB C
)C D
{ 	
this 
. 
Hide 
( 
) 
; 
Listar_Curso 
listar_Curso %
=& '
new( +
Listar_Curso, 8
(8 9
)9 :
;: ;
listar_Curso   
.   
Show   
(   
)   
;    
}!! 	
private## 
void## !
Registrobutton1_Click## *
(##* +
object##+ 1
sender##2 8
,##8 9
	EventArgs##: C
e##D E
)##E F
{$$ 	
this%% 
.%% 
Hide%% 
(%% 
)%% 
;%% 
Registro_Curso&& 
registro_Curso&& )
=&&* +
new&&, /
Registro_Curso&&0 >
(&&> ?
)&&? @
;&&@ A
registro_Curso'' 
.'' 
Show'' 
(''  
)''  !
;''! "
}(( 	
})) 
}** Ì

mC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Curso\Registro_Curso.cs
	namespace 	
CapaPresentacion
 
. 
InterfacesGraficas -
{ 
public 

partial 
class 
Registro_Curso '
:( )
Form* .
{ 
public 
Registro_Curso 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void (
AlumnoIDtextBox4_TextChanged 1
(1 2
object2 8
sender9 ?
,? @
	EventArgsA J
eK L
)L M
{ 	
} 	
private 
void 
AtrasButton1_Click '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
this 
. 
Hide 
( 
) 
; 
MenuPrincipal 
menuPrincipal '
=( )
new* -
MenuPrincipal. ;
(; <
)< =
;= >
menuPrincipal 
. 
Show 
( 
)  
;  !
} 	
} 
}   ¡
fC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\MenuPrincipal.cs
	namespace 	
CapaPresentacion
 
{ 
public 

partial 
class 
MenuPrincipal &
:' (
Form) -
{ 
public 
MenuPrincipal 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
MenuPrincipal_Load '
(' (
object( .
sender/ 5
,5 6
	EventArgs7 @
eA B
)B C
{ 	
} 	
private 
void 
Becasbutton_Click &
(& '
object' -
sender. 4
,4 5
	EventArgs6 ?
e@ A
)A B
{ 	
this 
. 
Hide 
( 
) 
; 
Becas_principal   
	beca_main   %
=  & '
new  ( +
Becas_principal  , ;
(  ; <
)  < =
;  = >
	beca_main!! 
.!! 
Show!! 
(!! 
)!! 
;!! 
}"" 	
private$$ 
void$$ &
Calificacionesbutton_Click$$ /
($$/ 0
object$$0 6
sender$$7 =
,$$= >
	EventArgs$$? H
e$$I J
)$$J K
{%% 	
this&& 
.&& 
Hide&& 
(&& 
)&& 
;&& 
M_Calificaciones'' 
m_Calificaciones'' -
=''. /
new''0 3
M_Calificaciones''4 D
(''D E
)''E F
;''F G
m_Calificaciones(( 
.(( 
Show(( !
(((! "
)((" #
;((# $
})) 	
private++ 
void++ 
Cursobutton_Click++ &
(++& '
object++' -
sender++. 4
,++4 5
	EventArgs++6 ?
e++@ A
)++A B
{,, 	
this-- 
.-- 
Hide-- 
(-- 
)-- 
;-- 
M_Curso.. 
m_Curso.. 
=.. 
new.. !
M_Curso.." )
(..) *
)..* +
;..+ ,
m_Curso// 
.// 
Show// 
(// 
)// 
;// 
}00 	
private22 
void22 
SalirButton_Click22 &
(22& '
object22' -
sender22. 4
,224 5
	EventArgs226 ?
e22@ A
)22A B
{33 	
if44 
(44 

MessageBox44 
.44 
Show44 
(44  
$str44  /
,44/ 0
$str441 8
,448 9
MessageBoxButtons44: K
.44K L
YesNo44L Q
,44Q R
MessageBoxIcon44S a
.44a b
Question44b j
,44j k$
MessageBoxDefaultButton	44l É
.
44É Ñ
Button1
44Ñ ã
)
44ã å
==
44ç è
System
44ê ñ
.
44ñ ó
Windows
44ó û
.
44û ü
Forms
44ü §
.
44§ •
DialogResult
44• ±
.
44± ≤
Yes
44≤ µ
)
44µ ∂
{55 
this66 
.66 
Close66 
(66 
)66 
;66 
}77 
}88 	
private;; 
void;; 
AlumnosButton_Click;; (
(;;( )
object;;) /
sender;;0 6
,;;6 7
	EventArgs;;8 A
e;;B C
);;C D
{<< 	
this== 
.== 
Hide== 
(== 
)== 
;== 
M_alumno>> 
m_Alumno>> 
=>> 
new>>  #
M_alumno>>$ ,
(>>, -
)>>- .
;>>. /
m_Alumno?? 
.?? 
Show?? 
(?? 
)?? 
;?? 
}@@ 	
}AA 
}BB §
nC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Menu_principal_alumno.cs
	namespace 	
CapaPresentacion
 
{ 
internal 
class !
Menu_principal_alumno (
{ 
public !
Menu_principal_alumno $
($ %
)% &
{ 	
}		 	
internal 
static 
void 
Show !
(! "
)" #
{ 	
} 	
} 
} Ñ
`C:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Program.cs
	namespace 	
CapaPresentacion
 
{		 
internal

 
static

 
class

 
Program

 !
{ 
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
MenuPrincipal ,
(- .
). /
)/ 0
;0 1
} 	
} 
} õ
pC:\Users\artur\Downloads\Calidad_Proyecto 4\Calidad_version_1-master\CapaPresentacion\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 

AssemblyTitle 
( 
$str +
)+ ,
], -
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str -
)- .
]. /
[ 
assembly 	
:	 

AssemblyCopyright 
( 
$str 0
)0 1
]1 2
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *