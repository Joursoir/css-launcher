   M S B A M L   `   `   `  ���� H  DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  F BcssLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperDesignSuperDesign !   SuperDesign.Settings_Window   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     +localclr-namespace:SuperDesign       � Title$  Настройки��$	��250��$	��510�� � 
ResizeMode$ NoResize=�����  �� ImageSource$ settings_background.jpg��.��� $��15q� � ColumnDefinitions �� $��85 ��� $��6 ���  � RowDefinitions �� $��20 ��� $��85 ��� .+��� $��2��$��0��   AccentColorBrush#���   �� $��2��$��0��$��
Sitka Text)� �� TextAlignment$
 Left=�$��Center=�
�������$��5 0 0 0q�ПАРАМЕТРЫ�� $��2��$��1��$��3��#���    J� Opacity$	 0.5Q��� $��0��$��0��#���   �� $��0��$��0��$��
Sitka Text)�$
 Left=�$��Center=�
�������$��5 0 0 0q�АВАТАР�� $��0��$��1��#���   $	 0.5Q��� -   $��buttonAvatar��$��0��$��1������ .R��� $��imageAvatar��$��reset_icon.png��$��70��$��70��$
��Fill=��� $��2��$��1��$��3��$��
Sitka Text)�$ Right=�$��
0 13 240 0q�$��16(�
�������ЯЗЫК ИГРЫ�� -    ��Name$ 
s_language��$��2��$��1��$��3��$��10��$	��220��$��Center=�$��Right=�$��14(�$��
0 0 10 125q��� $��2��$��1��$��3��$��
Sitka Text)�$ Right=�$��0 53.65 240 0q�$��16(�
�������СТРОКА ЗАПУСКА�� -    ��Name$ s_line��$��2��$��1��$��3��$��10��$	��190��	 �� TextAlignment$	 Center=�$��Center=�$��Right=�$��14(�$��	0 0 40 45q��� -   
 ��Name$
 reset_sline��$��2��$��1��$��3��$��25��$��Center=�$��Right=�$��0,48.5,10,93q�.���� $��reset_icon.png��$��-1q��� $��2��$��1��$��3��$��
Sitka Text)�$ Right=�$��0 94.25 240 0q�$��16(�
�������КЛАН-ТЕГ�� -   $ 	s_clantag��$��2��$��1��$��3��$��10��$	��220��$	 Center=�$��Center=�$��Right=�$��14(�$��
0 89 10 53q��� $��2��$��1��$��3��$��
Sitka Text)�$ Right=�$��0 135 240 0q�$��16(�
�������ПОКАЗ АВАТАРОВ)   #MahApps.Metro.Controls.ToggleSwitch  -     Name$ s_avatar��$��2��$��1��$��3��   OnLabel$  ��   OffLabel$  ��$��0,124,165,6q�$��Right=��� -   $
 s_accept_change��$��2��$��1��$��3��$��ПРИМЕНИТЬ��$��15��$��80��$��Right=�$��0, 127.5, 10, 12.5q�