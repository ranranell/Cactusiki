   M S B A M L   `   `   `  ����D  @Cactusiki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Cactusiki.PagesCactusiki.Pages  5   	   $    Cactusiki.Pages.AdminAddWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Cactusiki.Pages     5   	     � Title$  AdminAddWindow��5   	   $	��450��6    $	��800��6-   .��5	      � 
������� � RowDefinitions 5
   
   �� 5      $��0* �6   �� 5      $
��193* �6   �� 5      $	��32* �6    � ColumnDefinitions 5   
   �� 5      $	��230 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��1��6%   $
��Left=�62   $��Center=�6M   $��70,0,0,0q�6h   .+�5      �� 
�������$��2q�6(    �� CornerRadius$ 5,5,5,5��6<   $��Center=�6S   $��5q�6p   $	��150��6{   ._�5      �� -   5         ��Name$ IPicture��5      $	��200��6*   $	��150��6:   $��5q�6J   5      � 5      $��Center=�6   $��0 0 0 5q�65   .+�5      �� -   5         ��Name$ BtnAddImage��5      $��18(�6H   $��29��6V   .��5      �� $��/Images/Add_Photo.png��6    J� OpacityMask
 �   �6;   5      5      5      �� 5   
   $��1��6   $��1��6%   $
��Left=�62   $��32.6,89,0,103q�6M   .+�5      � $��0 0 0 5q�6   .+�5      �� $��Название:��6   $��0 0 31 0q�6-   �� 5       -   5         ��Name$ TxtName��5       $	��200��6+   67   5!      � 5"      $��0 0 0 5q�6   � 5#      $��0 0 0 5q�6   .+�5$      �� $��0 0 17 0q�6   �� 6/    � Language$ ru-ru�63   $�Вид:��6D   6S   �� 5%      -   5        	 ��Name$	 CmbxMaxDiscount��5%   '   $	��100��6   $��0 0 15 0q�6@   ��5&      �� 5'      .R�5(      �� ��6(   �� *
Views.Name+5)      5+      5,      � 5-      $��0 0 0 5q�6   .+�5.      �� $��Страна:��6   $��0 0 31 0q�6+   �� 5/      -   5        $ 
TxtCountry��5/      $	��200��6.   6:   50      � 51      $��0 0 0 5q�6   .+�52      �� $��Возраст:��6   $��0 0 31 0q�6,   �� 53      -   5        $ TxtAge��53      $	��200��6*   66   54      � 55      $��0 0 0 5q�6   .+�56      �� $��0 0 13 0q�6   �� 6/   $ ru-ru�63   $�Цена��6D   �� 6R   $�:��6V   6b   �� 57      -   5        $ TxtCount��57      $	��200��6,   68   58      59      �� 5:   
   $��1��6   $��2��6%   $
��Left=�62   $	��Top=�6M   $��252.6,10,0,0q�6e   $��25��6{   $	��238��6�   .+�5;      �� -   5        $ BtnAdd��5;   /   $#��Добавить запись��6   ���	#FFFD5A86$
��auto��6k   $
��auto��6y   $��-200 0 200 0q�6�   5<      5=      5>      