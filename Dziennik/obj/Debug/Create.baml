   M S B A M L   `   `   `  ����C  ?Dziennik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DziennikDziennik  5   	       Dziennik.Create   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Dziennik     5   	     � 
ResizeMode$  NoResize=�5   	    � Icon$ Images\tom.jpg��5	   	    � Title$. (Dziennik Toma Riddle'a - Tworzenie wpisu��5
   	   $	��550��6:   $	��500��6G   .��5      �  � RowDefinitions 5   
   �� 5      $	��49* �6   �� 5      $
��211* �6   ��5   
   �� 5       �� ImageSource$ Images\tom.jpg��6    j� Stretch$ UniformToFill=�66   .+�5   
   �� $��41,10,53,34q�6   $��20(�6%   $
��Bold"�63   
�������$��Viner Hand ITC)�6X   .��6u   -+Wybierz dzień, z którego dodać notatkę:6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ 	Calendar1��5      $
��Left=�6&   $��	41,64,0,0q�6A   $	��Top=�6T   $��2��6l   6}   �� 5   
   $��41,162,272,215q�6   $��20(�6(   $
��Bold"�66   
�������$��Viner Hand ITC)�6[   $��1��6w   .��6�   Treść wpisu:6�   �� 5   
   -   5        $
��Text��5      $��41,212,36,94q�6    �� TextWrapping$
 Wrap=�64    �� AcceptsReturn . 	 J� Opacity$		 0.8Q�6]   $��1��6k   6z   �� 5   
   -   5        
 ��Name$	
 Add��5      $��319,363,36,30q�6   $��1��6G   .��6T   
Dodaj wpis6`   5      5      