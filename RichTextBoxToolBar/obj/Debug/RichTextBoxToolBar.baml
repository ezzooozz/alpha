   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R8clr-namespace:System.ComponentModel;assembly=WindowsBaseSystem.ComponentModel  5   
   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   
   M IRichTextBoxToolBar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:RichTextBoxToolBarRichTextBoxToolBar 5   
   +   %RichTextBoxToolBar.RichTextBoxToolBar   5   
   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml      5   
   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006      5   
   @d2http://schemas.microsoft.com/expression/blend/2008      5   
   SComponentModel8clr-namespace:System.ComponentModel;assembly=WindowsBase      5   
   9System&clr-namespace:System;assembly=mscorlib      5   
   2local clr-namespace:RichTextBoxToolBar      5   
     � DataContext  5
   
   ��  �� RelativeSource �� *Self+ � 	Resources 5       S� ObjectInstance!  System.Windows.Media.Colors S� 
MethodName   colorProvider  systemFontSizes �� Type  systemFontFamilies �� Source   System.Windows.Media.Fonts   SystemFontFamilies �� Source	 �� SortDescriptions+   %System.ComponentModel.SortDescription
   PropertyName  colorItemTemplate �� Orientation �� CornerRadius � ToolTip��%�  &	        &	 6     &	     &	 u    S� 5   
   "  6   $ GetProperties��6>   6Y   S� 5   
    5      �� 5      " X�6   .s�5      X�8Q�6'   X�5      9Q�6'   X�5      10Q�6(   X�5      11Q�6(   X�5      12Q�6(   X�5      14Q�6(   X�5      16Q�6(   X�5      18Q�6(   X�5      20Q�6(   X�5      22Q�6(   X�5      24Q�6(   X�5      26Q�6(   X�5      28Q�6(   X�5      36Q�6(   X�5      48Q�6(   X�5      72Q�6(   5       5"      �� 5#   
    6:   �� # Z 	 5$        5%      $
 Source��61   5'      �� 5(   
   .R�5)      �� $ 
Horizontal=�6   $	��5,0q�5*      .+�5+      �� $��1q�6   $ 2��5,      
���   �$��25��5.      $��Stretch=�5/      ��50      �� *Name+�� 51      $��8,0,0,0q�53      ��51      �� *Name+ 52      �� *Name+53      54      55      56      .@�59      �� -   5         ��Name$ _cbFontFamily��59      $	��150��5:       �� 
IsEditable .   �� IsTextSearchEnabled . {�5<      �� *IsEnabledToolBarItems+��5?   
   �� 5@      .R�5A      ��  %� IsVirtualizing . .+�5B      �� ��5C      �� *Source+ 5D      �� *Source+5E      5F      ��5H   
   �� 5I      # [ 6   5K      �� 5L      -   5        $ _cbFontSize��5L       .  .  $��45��5P      {�5M      �� *IsEnabledToolBarItems+��5S   
   �� 5T      .R�5U      ��  . $ 
Horizontal=�6J   .+�5V      �� ��6    ��  61   �� 5W      5X      ��5Z   
   �� 5[      # [ 6   5]      d� 5^      -   5         d�Name$ 
_tgbtnBold��5^      .  (System.Windows.Documents.EditingCommands   
ToggleBold#��Z 5`      {�5_      �� *IsEnabledToolBarItems+��5a      �� *CurrentEditor+.��5b   
   �� $&�� Resources/ToolBarImages/Bold.png��6   $��16��5c      $��16��6   5d      d� 5e      -   5        $ _tgbtnItalic��5e         ToggleItalic#��Z 5g      {�5f      �� *IsEnabledToolBarItems+��5h      �� *CurrentEditor+.��5i   
   �� $(��"Resources/ToolBarImages/Italic.png��6   $��16��5j      $��16��6   5k      d� 5l      -   5        $ _tgbtnUnderline��5l         ToggleUnderline#��Z 5n      {�5m      �� *IsEnabledToolBarItems+��5o      �� *CurrentEditor+.��5p   
   �� $+��%Resources/ToolBarImages/Underline.png��6   $��16��5q      $��16��6   5r      	� 5s      -   5         	�Name$ _tgbtnSubscript��5s       	� 	GroupName$ Baseline��5t         ToggleSubscript#��Z 5v      {�5u      �� *IsEnabledToolBarItems+��5w      �� *CurrentEditor+.��5x   
   �� $+��%Resources/ToolBarImages/Subscript.png��6   $��16��5y      $��16��6   5z      	� 5{      -   5        $ _tgbtnSuperscript��5{      $ Baseline��5|         ToggleSuperscript#��Z 5~      {�5}      �� *IsEnabledToolBarItems+��5      �� *CurrentEditor+.��5�   
   �� $-��'Resources/ToolBarImages/Superscript.png��6   $��16��5�      $��16��6   5�      �� 5�      $+��%Resources/ToolBarImages/Textcolor.png��6   $��16��6;   $��16��6F   �� 5�      -   5        $ _cbForegroundColors��5�       �� DisplayMemberPath$
 Name��5�       .   . $��58��5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� # [  ��5�      �� # [ 5�      	� 5�      -	   5        $ _tgbtnAlignLeft��5�      $ 	Alignment��5�         	AlignLeft#��Z 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $+��%Resources/ToolBarImages/AlignLeft.png��6   $��16��5�      $��16��6   5�      	� 5�      -
   5        $ _tgbtnAlignCenter��5�      $ 	Alignment��5�         AlignCenter#��Z 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $-��'Resources/ToolBarImages/AlignCenter.png��6   $��16��5�      $��16��6   5�      	� 5�      -   5        $ _tgbtnAlignRight��5�      $ 	Alignment��5�         
AlignRight#��Z 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $,��&Resources/ToolBarImages/AlignRight.png��6   $��16��5�      $��16��6   5�      	� 5�      -   5        $ _tgbtnAlignJustify��5�      $ 	Alignment��5�         AlignJustify#��Z 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $.��(Resources/ToolBarImages/AlignJustify.png��6   $��16��5�      $��16��6   5�      �� 5�      -   5         ��Name$ _btnIncreaseIndentation��5�          IncreaseIndentation#��Z  5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $5��/Resources/ToolBarImages/IncreaseIndentation.png��6   $��16��5�      $��16��6   5�      �� 5�      -   5        $ _btnDecreaseIndentation��5�      !   DecreaseIndentation#��Z! 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $5��/Resources/ToolBarImages/DecreaseIndentation.png��6   $��16��6I   $��16��6T   5�      	� 5�      -   5        $ _tgbtnBullets��5�      $ Marker��5�      "   ToggleBullets#��Z" 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $,��&Resources/ToolBarImages/BulletList.png��6   $��16��5�      $��16��6   5�      	� 5�      -   5        $ _tgbtnNumbering��5�      $ Marker��5�      #   ToggleNumbering#��Z# 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $-��'Resources/ToolBarImages/NumbersList.png��6   $��16��5�      $��16��6   5�      �� 5�      �� 5�      -   5        $ _btnCut��5�      .  (System.Windows.Input.ApplicationCommands
$   Cut#��Z$ 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $%��Resources/ToolBarImages/Cut.png��6   $��16��5�      $��16��6   5�      �� 5�      -   5        $ _btnCopy��5�      %   Copy#��Z% 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $&�� Resources/ToolBarImages/Copy.png��6   $��16��5�      $��16��6   5�      �� 5�      -   5        $ 	_btnPaste��5�      &   Paste#��Z& 5�      {�5�      �� *IsEnabledToolBarItems+��5�      �� *CurrentEditor+.��5�   
   �� $'��!Resources/ToolBarImages/Paste.png��6   $��16��5�      $��16��6   5�      5�      