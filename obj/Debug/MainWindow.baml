   M S B A M L   `   `   `  ����F  BcssLauncher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SuperDesignSuperDesign  5   	   H DMahApps.Metro, Version=1.6.5.1, Culture=neutral, PublicKeyToken=nullV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls 5   	       SuperDesign.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SuperDesign     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   -   5        $	��355��5	   	   $	��300��6     � 
ResizeMode$  NoResize=�5
   	   (  "MahApps.Metro.Controls.MetroWindow   ShowIconOnTitleBar .     ShowTitleBar .    AccentColorBrush   	GlowBrush# �   5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5      ��5      �� 5   
    �� ImageSource$ main_background1.jpg��6    j� Stretch$ Uniform=�68      LeftWindowCommands 5      +  %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        .��5      �� 	 �� Orientation$	 
Horizontal=�6   .+�5      �� $��16��6   $��16��6'   $��settings.png��63   5      5      5      .��5"      � 
 � RowDefinitions
 5#   
   �� 5$      $��35 �6   �� 5%      $��75 �6   �� 5'      $��40 �6   �� 5(      $��40 �6   �� 5)      .+�5,   
   �� $��1��6   .+�5-      �� $��
Sitka Text)�6   $��36(�60   
������� �� TextAlignment$ Center=�5.      ��5-   >   Z� cssLauncher5.   5   �� 5/      $��
Sitka Text)�6   $ Center=�60   
�������:8УДОБНЫЙ, МИНИМАЛИСТИЧНЫЙ, ТВОЙ6z   50      �� 52   
   -   5         ��Name$ loginBox��53      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$' !        ВВЕДИТЕ ЛОГИН��52      $��2��53   $    �� 	MaxLength$ 16��61   $��35��6@   $	��185��6L    �� TextAlignment$ Center=�54      $��Center=�6)   $��14(�6K   6\   �� 56   
   -   5        $��ИГРАТЬ��56   &   
�������$��3��57      $��35��6   $	��185��6+   59      5:      