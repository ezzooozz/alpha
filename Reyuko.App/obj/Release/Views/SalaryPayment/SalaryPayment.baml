   M S B A M L   `   `   `  ����   
Reyuko.App2    ,Reyuko.App.Views.SalaryPayment.SalaryPayment   a ]DevExpress.Xpf.Core.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  f bDevExpress.Xpf.Grid.v18.2.Core, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v18.2, Version=18.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  U	 QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes 	 
�������.��� .+�' 	 !MaterialDesignThemes.Wpf.PopupBox      ToggleContent$	  ...��$��32��$��20(�$��Right=�$��0,1,8,0q�$	��Top=�$��40��   PopupContent. �� .+��� -   $
��Left=�$��
10,10,20,0q�
������ $��0q�#��[" �$	��Top=�$	��120��.����  �� Orientation$ 
Horizontal=�.+��� $.��(/Reyuko.App;component/Icons/tutorial.png��$��23��$��23���� $��Play Tutorial��$��14(�$
��Left=�$��10,0,0,0q�$��Center=��� $	��335��$��30��$��	10,10,0,0q�$
��Left=�$	��Top=�$��Segoe)�$��20(�$��Normal$�$��Salary Payment��$
��Wrap=��� -   $��Right=�$��
0,12,355,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $)��#/Reyuko.App;component/Icons/new.png��$��20���� $
�� New��$��14(�$��Center=�$��Center=��� -   $��Right=�$��
0,12,280,0q�
������ $��0q�#��[" �$	��Top=�$��70��.���� $ 
Horizontal=�.+��� $,��&/Reyuko.App;component/Icons/detail.png��$��20���� $�� View��$��14(�$��Center=�$��Center=��� -   $��Right=�$��
0,12,215,0q�
������ $��0q�#��[" �$	��Top=�$��60��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/print.png��$��20���� $�� Print��$��14(�$��Center=�$��Center=��� -   $��Right=�$��
0,12,130,0q�
������ $��0q�#��[" �$	��Top=�$��80��.���� $ 
Horizontal=�.+��� $-��'/Reyuko.App;component/Icons/refresh.png��$��20���� $�� Refresh��$��14(�$��Center=�$��Center=��� -   $��Right=�$��	0,12,55,0q�
������ $��0q�#��[" �$	��Top=�$��70��.���� $ 
Horizontal=�.+��� $+��%/Reyuko.App;component/Icons/close.png��$��20���� $�� Cancel��$��14(�$��Center=�$��Center=��� $��Employee / ID��$
��Left=�$��	10,40,0,0q�$	��Top=�$��26���� $��Periode��$
��Left=�$��
177,40,0,0q�$	��Top=�$��26���� $��Recap��$
��Left=�$��
10,100,0,0q�$	��Top=��� $��Value Range��$
��Left=�$��177,100,0,0q�$	��Top=�*  $DevExpress.Xpf.Editors.SearchControl  -     Name$ Employee��$
��Left=�$��28��$��	10,64,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.212,1&�$	��152��(  "System.Windows.Controls.DatePicker  $
��Left=�$��28��$��
177,64,0,0q�$	��Top=�$	��110��  $
��Left=�$��28��$��
300,64,0,0q�$	��Top=�$	��110���� -    ��Name$ cbRecap��$
��Left=�$��
10,125,0,0q�$��28��$	��Top=�$	��152���� -	    ��Name$ txtvalue��$
��Left=�$��28��$��177,125,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��110���� -
   $ txtRange��$
��Left=�$��28��$��300,125,0,0q�$
 Wrap=�$	��Top=�$	��110��&   System.Windows.Controls.DataGrid  -     Name$ DGSalaryPayment��$
��Auto��$	��400��$��
10,167,0,0q�	   AutoGenerateColumns	 .  $��0q�
   CanUserResizeRows
 .     ColumnHeaderHeight$ 32Q�$��14(�   GridLinesVisibility$
 None=�   HeadersVisibility$ Column=�   
IsReadOnly .    RowDetailsVisibilityMode$ Visible=�   	RowHeight$ 30Q�   SelectionMode$ Single=���Z� ��Z�  � 	Resources =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� BasedOn �� 
TargetType �� Property �� Value��%p   '        7 �� 8   "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 120    CanUserReorder .     CanUserResize .     CanUserSort .    FontSize$ 14Q�   Header$ Salary Payment No��1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding �� *NoSalaryPayment+   HeaderStyle �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  	  ElementStyle  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$
 Date�� �� *TglSalaryPayment+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ Employee / ID�� �� *
IDEmployee+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Basic Salary�� �� *BasicSalary+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ 	Allowance�� �� *	Allowance+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Total Overtime�� �� *TotalOvertime+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Others�� �� *Other+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 60  .   .   . $ 14Q�$	 Tax�� �� *Tax+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$
 Note�� �� *Note+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 120  .   .   . $ 14Q�$ 	Bank Data�� �� *
BankData+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $	 100  .   .   . $ 14Q�$ Total�� �� *Total+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$ 
Department�� �� *
Department+ �� # [B "  .���  � ��$
 Left=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�  $ 80  .   .   . $ 14Q�$ Project�� �� *	Project+ �� # [B "  .���  � ��$ Center=���  � �� �	#FF5684C3��  � ��
 �����  �� # [B��" ��.���  �@��TextAlignment$ Center=���  � ��$ Center=�