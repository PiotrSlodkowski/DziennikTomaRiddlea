   M S B A M L   `   `   `  ���� O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem  C ?Dziennik, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DziennikDziennik    Dziennik.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6sys&clr-namespace:System;assembly=mscorlib     (localclr-namespace:Dziennik       � 
ResizeMode$  NoResize=� � Icon$ Images\tom.jpg�� � Title$ Dziennik Toma Riddle'a��$	��600��$	��700��.��� ����  �� ImageSource$ Images\tom.jpg�� j� Stretch$ UniformToFill=�.+��� $��41,10,193,511q�$��20(�$
��Bold"�
�������$��Viner Hand ITC)�.��/-Wybierz dzień, z którego wyświetlić wpis:&   System.Windows.Controls.Calendar  -     Name$ 	Calendar1��$
��Left=�$��	41,59,0,0q�$	��Top=��� -    ��Name$
 Load��$��41,232,472,304q�.��
Alohomora!�� -   $	 Add��$��41,271,472,265q�.��Utwórz notatkę!�� $��41,346,249,169q�$��20(�$
��Bold"�
�������$��Viner Hand ITC)�.��Zaklęcie na dziś:�� -    ��Name$ Spell��$
��Left=�$��41,406,0,94q� �� 
IsReadOnly . 	 �� TextWrapping$
	 Wrap=�
 �� AcceptsReturn
 .  J� Opacity$	 0.8Q�$	��479���� $��41,481,388,44q�$��20(�$
��Bold"�
�������$��Viner Hand ITC)�.��Twój nastrój w skali 1-5:�� -    ��Name$ Humor��$
��Left=�$��304,481,0,0q�$	��Top=�$��Center=�$��Center=�$��34��.@���  �� 
IsSelected . $��5���� $��4���� $��3���� $��2���� $��1���� -   $
 Rand��$��41,526,472,10q�.��Losuj zaklęcie!