   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  5   	   C ?Dziennik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DziennikDziennik 5   	      Dziennik.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6sys&clr-namespace:System;assembly=mscorlib     5   	   (localclr-namespace:Dziennik     5   	     � 
ResizeMode$  NoResize=�5   	    � Icon$ Images\tom.jpg��5
   	    � Title$ Dziennik Toma Riddle'a��5   	   $	��600��6(   $	��700��65   .��5      � ��5   
   �� 5       �� ImageSource$ Images\tom.jpg��6    j� Stretch$ UniformToFill=�66   .+�5   
   �� $��41,10,193,511q�6   $��20(�6'   $
��Bold"�65   
�������$��Viner Hand ITC)�6Z   .��6v   /-Wybierz dzień, z którego wyświetlić wpis:6�   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ 	Calendar1��5      $
��Left=�6&   $��	41,59,0,0q�6A   $	��Top=�6T   5      �� 5   
   -   5         ��Name$
 Load��5      $��41,232,472,304q�6   .��6K   
Alohomora!6W   �� 5   
   -   5        $	 Add��5      $��41,271,472,265q�6   .��6H   Utwórz notatkę!6Y   �� 5   
   $��41,346,249,169q�6   $��20(�6(   $
��Bold"�66   
�������$��Viner Hand ITC)�6[   .��6w   Zaklęcie na dziś:6�   �� 5   
   -   5         ��Name$ Spell��5      $
��Left=�6!   $��41,406,0,94q�6<    �� 
IsReadOnly . 	 �� TextWrapping$
	 Wrap=�6c   
 �� AcceptsReturn
 .  J� Opacity$	 0.8Q�6�   $	��479��6�   �� 5   
   $��41,481,388,44q�6   $��20(�6'   $
��Bold"�65   
�������$��Viner Hand ITC)�6Z   .��6w   Twój nastrój w skali 1-5:6�   �� 5   
   -   5         ��Name$ Humor��5      $
��Left=�6"   $��304,481,0,0q�6=   $	��Top=�6R   $��Center=�6j   $��Center=�6�   $��34��6�   .@�5      ��  �� 
IsSelected . $��5��6-   �� 5      $��4��6   �� 5      $��3��6   �� 5      $��2��6   �� 5      $��1��6   5      �� 5   
   -   5        $
 Rand��5      $��41,526,472,10q�6   .��6I   Losuj zaklęcie!6Z   5       5!      