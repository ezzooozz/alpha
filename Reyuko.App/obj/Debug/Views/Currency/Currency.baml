   M S B A M L   `   `   `  ����  
Reyuko.App(    "Reyuko.App.Views.Currency.Currency   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $	��Top=�5
      
�������  � 	Resources  5         MyButton �� 
TargetType �� Property �� Value �� 
TargetType �� Triggers P� Property P� Value��%�  &	        �� 5   
   " ��6!   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       �@�Cursor$
 Hand��6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0q�6/   
���   �#��z��6W   ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  �@J�Opacity$	 0.8Q�6<   5      5      5      5      5       .��5#      � .+�5%   
   �� -   5         ��Name$ 
LICurrency��5&      $	��200��5'      $	��632��5(      $��
8,69,0,-12q�5)      $
��Left=�5*      ��5,      �� 5-      .R�5.      �� $��46��5/      $��0,0,0,0q�50      	 �� Orientation$	 
Horizontal=�51      .+�52      �� $��44��53      $��26��54      $��0,10,1,8q�55      $��Center=�56      $��Center=�57      ��58      �� *KodeMataUang+�� 59      $��2��5:      $	��121��5;      $��0,2,0,10q�5<      $
��Wrap=�5=      �� 5>      ��6(   �� *NamaMataUang+�� 6I   �� 5?      ��6(   �� *	KursTukar+5B      5E      5G      5v      &   System.Windows.Controls.DataGrid  5x   
   -   5        
  Name$
 DGCurrencyDetail��5y      $
��Auto��5z      $	��400��5{      $��213,69,0,-12q�5|         AutoGenerateColumns .  $��0q�5�         CanUserResizeRows .     ColumnHeaderHeight$ 32Q�5�      $
��12.5(�5�         GridLinesVisibility$
 None=�5�         HeadersVisibility$ Column=�5�         
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�5�         	RowHeight$ 30Q�5�         SelectionMode$ Single=�5�      ��5~      Z� ��5      Z�   5�      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn��%�   '        7 �� 5�      8   "  6Q   .�5�      ��  � ��$ Center=�6C   �� 5�       � �� �	#FF5684C363   �� 5�       � ��
 �����63   5�      5�         Columns 5�      0  *System.Windows.Controls.DataGridTextColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 160 5�         CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$
 12.5Q�5�         Header$
 Date��5�      1  +System.Windows.Controls.DataGridBoundColumn   Binding 5�      �� *	Tanggal+   HeaderStyle 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�         ElementStyle 5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $	 180 5�       .   .   . $
 12.5Q�5�      $ Currency��5�       5�      �� *KodeMataUang+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $	 150 5�       .   .   . $
 12.5Q�5�      $
 Rate��5�       5�      �� *Exrate+ 5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�        5�      $ * 5�       .   .   . $
 12.5Q�5�      $ Up Date��5�       5�      �� 5�      # [B 6    "  6Y   .�5�      ��  � ��$ Center=�6K   �� 5�       � �� �	#FF5684C36;   �� 5�       � ��
 �����6;   5�       5�      �� 5�      # [B��6    " ��6N   .�5�      ��  �@��TextAlignment$ Center=�6H   �� 5�       � ��$ Center=�6L   5�      5�      5�      �� 5�   
   $	��252��5�      $��42��5�      $��	10,10,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Segoe)�5�      $��36(�5�      $��Normal$�5�      $��Currency Data��5�      $
��Wrap=�5�      '  !MaterialDesignThemes.Wpf.PopupBox  5�   
      ToggleContent$	 ...��6"   $��32��66   $��18(�6B   $��Right=�6P   $��0,3,8,0q�6l   $	��Top=�6~   $��40��6�       PopupContent.  5�      �� .+�5�      �� -   5        $
��Left=�5�      $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5�      $	��Top=�6P   $	��125��6h   .��5�      �� $	 
Horizontal=�6!   .+�5      �� $.��(/Reyuko.App;component/Icons/currency.png��6    $��23��6R   $��23��6^   �� 5     $��Set as Default��6$   $
��12.5(�6:   $
��Left=�6J   $��10,0,0,0q�6e   $��Center=�6w   5     5     �� 5     -   5        $
��Left=�5     $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5     $	��Top=�6P   $	��140��6h   .��5     �� $	 
Horizontal=�6!   .+�5     �� $-��'/Reyuko.App;component/Icons/setting.png��6    $��23��6Q   $��23��6]   �� 5     $��Account Setting��6$   $
��12.5(�6;   $
��Left=�6K   $��10,0,0,0q�6f   $��Center=�6x   5	     5
     �� 5     -   5        $
��Left=�5     $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5     $	��Top=�6P   $	��105��6h   .��5     �� $	 
Horizontal=�6!   .+�5     �� $+��%/Reyuko.App;component/Icons/close.png��6    $��23��6O   $��23��6[   �� 5     $��
Deactivate��6$   $
��12.5(�66   $
��Left=�6F   $��10,0,0,0q�6a   $��Center=�6s   5     5     �� 5     -   5        $
��Left=�5     $��
10,10,20,0q�64   
������ $��0q�6a   #��[" �5     $	��Top=�6P   $	��120��6h   .��5     �� $	 
Horizontal=�6!   .+�5     �� $.��(/Reyuko.App;component/Icons/tutorial.png��6    $��23��6R   $��23��6^   �� 5     $��Play Tutorial��6$   $
��12.5(�69   $
��Left=�6I   $��10,0,0,0q�6d   $��Center=�6v   5     5     5     5     �� 5  
   -   5        $��Right=�5     $��
0,12,190,0q�6-   
������ $��0q�6Z   #��[  5     $	��Top=�6/   $��60��6G   .��5     �� $	 
Horizontal=�6   .+�5     �� $)��#/Reyuko.App;component/Icons/new.png��6   $��20��6E   �� 5      $
�� New��6   $
��12.5(�6(   $��Center=�68   $��Center=�6U   5!     5"     �� 5$  
   -   5        $��Right=�5$     $��	0,12,55,0q�6-   
������ $��0q�6Y   #��[  5%     $	��Top=�6/   $	��130��6G   .��5&     �� $	 
Horizontal=�6   .+�5'     �� $*��$/Reyuko.App;component/Icons/edit.png��6   $��20��6F   �� 5(     $�� Ex Rate Update��6   $
��12.5(�63   $��Center=�6C   $��Center=�6`   5)     5*     5-     5/     