   M S B A M L   `   `   `  ����H  DWpfHelloWorld, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfHelloWorldWpfHelloWorld  5   	       WpfHelloWorld.MyWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WpfHelloWorld     5   	   -   5          � Title$  MyWindow��5   	   $	��450��6   $	��800��6'    � 	Resources 5	       �� 
TargetType �� Property �� Value �� 
TargetType � Color � Offset � LayoutTransform	 �� Angle
 �� Triggers P� Property P� Value N� EnterActions ��Name g� Duration �� TargetProperty	 W� To N� ExitActions �� BeginStoryboardName �� Triggers  WpfHelloWorld.StudentList   studentCollection(  "WpfHelloWorld.BoolToBrushConverter  boolToBrushConverter  listBoxTemplate �� Orientation �� Path �� 	Converter��%�  '��       &	  u    &	 �    &	 �    7  �� 5
   
   " ��6   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 50��6*   �� 5       � ��$ 50��6)   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      �� ��5   "   
� 5   &   .��5   *   � $
 Blue��67   $ 0Q�6D   � 5   *   $ 
BlueViolet��67   $ 1Q�6J   5   '    5   "   �� 5   &   $	 45Q�66   5      �� 5      $��Center=�6/   $��Center=�6L   5      
 5      P� 5        �@J�IsMouseOver .  5!   "   �� 5"   &   $ 
Storyboard��66   .��5#   *   �� $ 0:0:1D�65   .��5$   .   W� $ FontSize�6>   $ 20X�6c   W� 5%   .   $ Width�6>   $	 100X�6`   W� 5&   .   $ Height�6>   $	 100X�6a   5'   +   5(   '    5*   "   �� 5+   &   $ 
Storyboard��65   5-      5/      51       52      5Z        5\   
   6     5]   
   6%   �� 5^   
   .R�5_      �� $ 
Horizontal=�6   .+�5`      �� $��10��5a      $��10��5b      $��0,0,5,0q�5c      ��5`      �� $ 
IsEnrolled�8   5c      �� 5d      ��6   �� $ StudentName�5e      5f      5h      .��5i      � .+�5k   
   �� -   5        $��Button��5k      $
��Left=�6"   $��
89,148,0,0q�6=   $��70��6R   $��70��6^   $	��Top=�6i   6�   �� 5l   
   -   5        $��Button��5l      $
��Left=�6"   $��150,200,0,0q�6=   $��70��6S   $��70��6_   $	��Top=�6j   6�   �� 5m   
   -   5         ��Name$ textBox��5m      $��80��6%   $	��120��61   $��Center=�6=   $��	0,148,0,0q�6Z   $
��Wrap=�6m   $��	TextBlock��6�   $	��Top=�6�   �� 5n   
   -   5        $��listBox1��5o      $��60��5n      $
��Left=�6   $��	12,12,0,0q�5o      $	��Top=�5p      $	��250��6   #��[ 5r      ��5q      ��  �� Source# [  5r      5u      5v      