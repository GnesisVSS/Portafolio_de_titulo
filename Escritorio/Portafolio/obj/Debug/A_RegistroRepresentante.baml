   M S B A M L   `   `   `  ����E  APortafolio, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Portafolio
Portafolio  5      (    "Portafolio.A_RegistroRepresentante   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:Portafolio     5      _ [MaterialDesignThemes.Wpf, Version=4.2.1.2, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $
��1116��5      $	��690��6,   .��5	      � 
�������.+�5
   
   )  #MaterialDesignThemes.Wpf.DialogHost     MaterialDesignDevider#���   6$       DialogContent  5      � 5      $	��300��6   $	��150��6#   $��Center=�60   .+�5      ��  �� Orientation$ 
Horizontal=�6!   $��15q�6:   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ QuestionMark=�62     PrimaryHueMidBrush#��[ 6F   $��50��6w   $��50��6�   �� 5      
�������$	��200��66   $
��15 5q�6B   $
��Wrap=�6P   75Desea registrar en el sistema a la empresa ingresada?5      5      �� 5      $ 
Horizontal=�6!   $��Right=�6:   $��Bottom=�6V   $��15q�6q   .+�5      ��    CloseDialogCommand#��Z 6!     MaterialDesignFlatButton#���  6c   $��4q�6�   $��Center=�6�   .��6�   
Cancelar5      5      �� 5      $ 
Horizontal=�6!   $
��Left=�6:   $��Bottom=�6U   $��15q�6p   .+�5      �� -   5         ��Name$ boton_confirmacion��5   !   #��Z 6=   #���  6   $��4q�6�   $��Center=�6�   .��6�   	Registrar5      5      5      .��5       �� -   5        $ btnRegistrarRepresentante��5       $��	Registrar��68   $��Bottom=�6M   $��52��6h   $��Right=�6t   $	��122��6�   $��	0,0,33,61q�6�   
�������
���   �$
��Bold"�6�      OpenDialogCommand#��Z 6  ��5!      �� 5"       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5#      �  � Color$ 	#FF00A2FF��6'   	 � Offset$	 0Q�69   � 5$      $ 	#FF1700FF��6'   $	 1Q�69   5%      5'      5(      �� 5)   
   -   5        
 ��Name$
 lblRunAsociado��5)      $��Run del Asociado��6(   $
��Left=�6C   $��388,126,0,0q�6^   $	��Top=�6s   �� 5*   
   -   5        $
 lblPrimerNombre��5*      $��Primer Nombre��6)   $
��Left=�6A   $��388,202,0,0q�6\   $	��Top=�6q   �� 5+   
   -   5        $
 lblApellido��5+      $��Apellido��6%   $
��Left=�68   $��388,282,0,0q�6S   $	��Top=�6h   �� 5,   
   -   5         ��Name$ txtRunAsociado��5,      $
��Left=�6*   $��24��6E   $��542,126,0,0q�6Q    �� TextWrapping$
 Wrap=�6f   $�� ��6z   $	��Top=�6�   $	��151��6�    �� 	MaxLength$ 9��6�   �� 5/   
   -   5        $ txtPrimerNombre��5/      $
��Left=�6+   $��24��6F   $��542,202,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��151��6�   $ 20��6�   �� 50   
   -   5        $ txtApellidoPaterno��50      $
��Left=�6.   $��22��6I   $��542,282,0,0q�6U   $
 Wrap=�6j   $�� ��6~   $	��Top=�6�   $	��151��6�   $ 20��6�   �� 51   
   $��Registro de Representante��6   $
��Left=�64   $��
292,42,0,0q�6O   $	��Top=�6c   ���	#FF5B5B5B$��36(�6�   $��Bahnschrift Light)�6�   $
��Bold"�6�   $��51��6�   �� 52   
   $��736,25,306,597q�6   $��	users.png��6(   $��Uniform=�6;   �� 53   
   $$��*Continuar Registro de Empresa��6   $
��Left=�69   $��947,626,0,0q�6T   $	��Top=�6i   $��9(�6�   �� 54   
   -	   5        $
 lblCargoRepresentante��54      $��Cargo��60   $
��Left=�6@   $��388,370,0,0q�6[   $	��Top=�6p   �� 55   
   -
   5        $ txtCargo��55   �   $
��Left=�6   $��23��6-   $��542,370,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��151��6�   $ 50��6�   �� 56   
   -   5        $
 lblTelefono��56   u   $��Numero de Telefono��6   $
��Left=�6-   $��388,455,0,0q�6H   $	��Top=�6]   6u   �� 57   
   -   5        $ txtTelefono��57   �   $
��Left=�6   $��23��6-   $��542,456,0,0q�69   $
 Wrap=�6N   $�� ��6b   $	��Top=�6j   $	��151��6�   $ 9��6�   �� 58   
   $��*ejemplo: 91111111��6   $
��Left=�6-   $��542,488,0,0q�6H   $	��Top=�6]   $��9(�6u   �� 59   
   -   5        $
 	lblGenero��59      $��Género��6#   $
��Left=�64   $��388,536,0,0q�6O   $	��Top=�6d   �� 5:   
   -   5         ��Name$ 	cboGenero��5:      $
��Left=�6&   $��542,536,0,0q�6A   $	��Top=�6V   $	��166��6n    J� RenderTransformOrigin$ 0.466,2.308&�6{   $��26��6�   .@�5;      �� $��Seleccione una opción��6   $
��Left=�6;   $	��164��6V   {�.  6b   �� 5<      $��	Masculino��6   $
��Left=�6/   $	��164��6J   �� 5=      $��Femenino��6   $
��Left=�6.   $	��164��6I   5>      5@      5B      