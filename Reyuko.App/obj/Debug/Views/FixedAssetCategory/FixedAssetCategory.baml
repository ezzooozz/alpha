   M S B A M L   `   `   `  ����  
Reyuko.App<    6Reyuko.App.Views.FixedAssetCategory.FixedAssetCategory   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $	��Top=�5
      
�������  � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5"      � .+�5$   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGFixedAssetCategory��5%      $
��Auto��5&      $	��400��5'      $��20,67,0,-10q�5(      	   AutoGenerateColumns	 .  $��0q�5,      
   CanUserResizeRows
 .     ColumnHeaderHeight$ 32Q�5.      $
��12.5(�5/         GridLinesVisibility$
 None=�50         HeadersVisibility$ Column=�51         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�53         	RowHeight$ 30Q�54         SelectionMode$ Single=�55      ��5*      Z� ��5+      Z�   56      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 57      8   "  6Q   .�58      ��  � ��$ Center=�6C   �� 59       � �� �	#FF5684C363   �� 5:       � ��
 �����63   5;      5>         Columns 5?      0  *System.Windows.Controls.DataGridTextColumn  5A      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 300 5B         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5G         Header$ Fixed Asset Category��5H      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5C      �� *NamaKelompokHartaTetap+   HeaderStyle 5I      �� 5J      # [B 6    "  6Y   .�5K      ��  � ��$
 Left=�6K   �� 5L       � �� �	#FF5684C36;   �� 5M       � ��
 �����6;   5N         ElementStyle 5P      �� 5Q      # [B��6    " ��6N   .�5R      ��  �@��TextAlignment$ Center=�6H   �� 5S       � ��$ Center=�6L   5T      5V        5W      $ 80 5X       .   .   . $
 12.5Q�5]      $
 Life��5^       5Y      �� *UmurEkonomis+ 5_      �� 5`      # [B 6    "  6Y   .�5a      ��  � ��$ Center=�6K   �� 5b       � �� �	#FF5684C36;   �� 5c       � ��
 �����6;   5d       5f      �� 5g      # [B��6    " ��6N   .�5h      ��  �@��TextAlignment$ Center=�6H   �� 5i       � ��$ Center=�6L   5j      5l        5m      $ * 5n       .   .   . $
 12.5Q�5s      $ Deprectiation Method��5t       5o      �� *NamaPenyusutan+ 5u      �� 5v      # [B 6    "  6Y   .�5w      ��  � ��$ Center=�6K   �� 5x       � �� �	#FF5684C36;   �� 5y       � ��
 �����6;   5z       5|      �� 5}      # [B��6    " ��6N   .�5~      ��  �@��TextAlignment$ Center=�6H   �� 5       � ��$ Center=�6L   5�      5�      5�      �� 5�   
   $	��360��5�      $��42��5�      $��	20,20,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Segoe)�5�      $��36(�5�      $��Normal$�5�      $��Fixed Asset Category��5�      $
��Wrap=�5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,10,8,0q�6l   $	��Top=�6   $��40��6�      PopupContent. 5�      �� .+�5�      �� -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $	��150��6h   .��5�      ��  �� Orientation$ 
Horizontal=�6!   .+�5�      �� $-��'/Reyuko.App;component/Icons/setting.png��6    $��23��6Q   $��23��6]   �� 5�      $��Account Setting��6$   $
��12.5(�6;   $
��Left=�6K   $��10,0,0,0q�6f   $��Center=�6x   5�      5�      �� 5�      -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $��90��6h   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $,��&/Reyuko.App;component/Icons/delete.png��6    $��23��6P   $��23��6\   �� 5�      $��Delete��6$   $
��12.5(�62   $
��Left=�6B   $��10,0,0,0q�6]   $��Center=�6o   5�      5�      �� 5�      -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $	��120��6h   .��5�      �� $ 
Horizontal=�6!   .+�5�      �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5�      $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5�      5�      5�      5�      �� 5�   
   -   5        $��Right=�5�      $��
0,20,120,0q�6-   
������ $��0q�6Z   #��[  5�      $	��Top=�60   $��60��6H   .��5�      �� $ 
Horizontal=�6   .+�5�      �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5�      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5�      5�      �� 5�   
   -   5        $��Right=�5�      $��	0,20,55,0q�6-   
������ $��0q�6Y   #��[  5�      $	��Top=�60   $��60��6H   .��5�      �� $ 
Horizontal=�6   .+�5�      �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5�      $�� Edit��6   $
��12.5(�6)   $��Center=�69   $��Center=�6V   5�      5�      5�      5�      