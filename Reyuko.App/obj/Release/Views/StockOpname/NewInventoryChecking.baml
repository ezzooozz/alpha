   M S B A M L   `   `   `  ����   
Reyuko.App7    1Reyuko.App.Views.StockOpname.NewInventoryChecking   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 $	��730��$��14(�  � 
ResizeMode$  NoResize=� � ShowInTaskbar .   � WindowStartupLocation$ CenterScreen=�
�������.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox     ToggleContent$	 ...��$��32��$��20(�$��Right=�$��0,1,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.����  �� Orientation$ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� $
��Left=�$��15��$��
330,70,0,0q�$	��Top=�$��15��$)��#/Reyuko.App;component/Icons/new.png���� $	��230��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��New Inventory Checking��$
��Wrap=��� -   $��Right=�$��
0,12,200,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $*��$/Reyuko.App;component/Icons/save.png��$��20���� $�� Save��$��14(�$��Center=�$��Center=��� -   $��Right=�$��
0,12,130,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/print.png��$��20���� $�� Print��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,55,0q�
������ $��0q�#��[" �$	��Top=�$��70��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��20���� $�� Cancel��$��14(�$��Center=�$��Center=��� $��Reference Number��$
��Left=�$��	10,40,0,0q�$	��Top=�$��26���� $��Refernce Document��$
��Left=�$��
175,40,0,0q�$	��Top=�$��26���� $��Account��$
��Left=�$��
350,40,0,0q�$	��Top=�$��26���� $
��Date��$
��Left=�$��
520,40,0,0q�$	��Top=��� $��	Staf / ID��$
��Left=�$��
680,40,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  -     Name$ DocumentReference��$
��Left=�$��28��$��
175,64,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.212,1&�$	��152��(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$��
520,64,0,0q�$	��Top=�$	��150���� -    ��Name$ 	cbAccount��$
��Left=�$��
350,64,0,0q�$��28��$	��Top=�$	��152��  -   $
 Staf��$
��Left=�$��28��$��
680,64,0,0q�$	��Top=�$ 0.212,1&�$	��152���� -   	 ��Name$	 txtReferenceNumber��$
��Left=�$��28��$��	10,64,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$	��152��&   System.Windows.Controls.DataGrid  -	     Name$ DGInventoryChecking��$
��Auto��$	��400��$��
10,112,0,0q�   AutoGenerateColumns .  $��0q�   CanUserResizeRows .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 200    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�    Header$    SKU / Name��1	  +System.Windows.Controls.DataGridBoundColumn! 	  Binding! �� *SKU+"   HeaderStyle" �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����# 	  ElementStyle# �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$  Satuan��! �� *Satuan+" �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����# �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 170  .   .   . $ 14Q�$  Inventory (Book)��! �� *InventoryBook+" �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����# �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 170  .   .   . $ 14Q�$  Inventory (On Hand)��! �� *InventoryHand+" �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����# �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 200  .   .   . $ 14Q�$  	Diference��! �� *	Diference+" �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����# �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�