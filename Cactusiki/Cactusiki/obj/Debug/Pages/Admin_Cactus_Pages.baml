   M S B A M L   `   `   `  ����D  @Cactusiki, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Cactusiki.PagesCactusiki.Pages  5      (    "Cactusiki.Pages.Admin_Cactus_Pages   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:Cactusiki.Pages     5        N� Title$  Admin_Cactus_Pages��5	      .��5      � 
������� � ColumnDefinitions 5   
   �� 5      �� 5      $	��10* �6   �� 5       � RowDefinitions 5   
   �� 5      $	��33* �6   �� 5      $	��47* �6   �� 5      $
��332* �6   �� 5      $	��38* �6   .+�5   
   � -   5         �Name$ panelHeader��5   ,   $��0��6   $��1��6   $	��Top=�6A   $��40��6Y   .+�5      �� $��Center=�6   $��Center=�65   
���   �$��20(�5   
   $��Arial)�6   $
��Bold"�6+   $��Italic$�6=   �� 6Q    � Language$ ru-ru�6U   $�Кактусы��6f   6x   5      �� 5   
   $��1��6   $��1��6"   $��Center=�62   .+�5      �� $��0 0 0 10q�6   $	��Top=�6+    �� Orientation$ 
Horizontal=�6C   .+�5      �� -   5         ��Name$ 	TxtSearch��5      $	��200��6Q   $��29��6]   $��Center=�6i   $��Center=�6�   �� 5      $��0q�6   
���   �
����� �$��18(�6I   $��29��6W   $��29��6b   {�.  .��5      �� $��/Images/поиск.png��6   5       �� 5!      -   5         ��Name$ 
BtnSort_az��5!      $��Right=�6-   $��0q�6I   
�������
����� �$��18(�6y   $��29��6�   $��29��6�   .��5"      �� $��/Images/sort.png��6   5#      �� 5$      -   5        $ BtnSort_delet��5$      $��Right=�60   $��0q�6L   
�������
����� �$��18(�6|   $��29��6�   $��29��6�   .��5%      �� $��/Images/Del.png��6   5&      �� 5'      -   5        $ BtnSort_add��5'      $��Right=�6.   $��0q�6J   
�������
����� �$��18(�6z   $��29��6�   $��29��6�   .��5(      �� $��/Images/Add.png��6   5)      �� 5*      -   5        $ BtnBAck��5*      $��
Назад��6*   $��75��6:   6E   5,      5-      �� 5.   
   $��2��6   $��1��6$   $��Visible=�64   $
��Auto=�6Z   .��5/      �� .+�50      �� -   5         ��Name$ LvCactus��50      ��51      �� 52      .R�53      A� 	 A� Columns$	 1��6*   54      ��56      �� 57      .R�58      �� $ 
Horizontal=�6)   $��Center=�6B   .+�59   "   �� $	��100��6(   $	��100��65   $��5q�6A   ��5:   &   �� 5;   *   
 �� Path$
 Image�62    �� TargetNullValue 5<   .   ��5=   2   /Images/picture.jpg��5?   3   5A   +   5C   #   �� 5D   "   $ Vertical=�6-   $��Center=�6D   $	��100��6_   $��5q�6k   .+�5E   &   �� $
��Wrap=�6M   ��60   �� *Cactus.Name+6M   �� 5G   &   $ Vertical=�61   .+�5H   *   �� $��Вид:��64   �� 5I   *   ��64   �� *
Views.Name+5J   '   �� 5K   &   $ 
Horizontal=�61   .+�5L   *   �� $��Страна: ��64   �� 5M   *   ��64   �� *Cactus.Origin+5N   '   �� 5O   &   $ 
Horizontal=�61   .+�5P   *   �� $��Возраст: ��64   �� 5Q   *   ��64   �� *
Cactus.Age+5R   '   5S   #   �� 5T   "   $ Vertical=�6-   $��5q�6D   $��Right=�6O   $��Center=�6k   .+�5U   &   �� $��Инструкция:��60   �� 5V   &   ��60   �� *Views.Instruction+5W   #   �� 5X   "   $ Vertical=�6-   $��5q�6D   $��Right=�6O   $��Center=�6k   .+�5Y   &   �� $��	Цена:��60   �� 5Z   &   ��60   �� *Cactus.Price+5[   #   5\      5]      5_      5`      5a      5c      5d      