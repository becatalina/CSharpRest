   M S B A M L   `   `   `  ����E  ARestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Restaurant.ViewModelsRestaurant.ViewModels  5   	   !    Restaurant.Views.MenuWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2vm#clr-namespace:Restaurant.ViewModels     5   	     � Title$  
MenuWindow��5   	   $	��450��6   $	��800��6)   ���#2e3137.��5      � ���#2e3137$��5q�6    .+�5   
   �� $��10,10,540.333,9.667q�6   .+�5      �� -   5         ��Name$ btnHome��5      $��
10,50,0,10q�5      ���#5d636f$
��HOME��5      
�������$��18(�5   (   $��42��66   $
��Left=�6B   $	��217��6]   �� 5      -   5        $ btnCart��5      $��
10,50,0,10q�5      ���#5d636f$��SHOPPING CART��5      
�������$��18(�5   (   $��42��66   $
��Left=�6B   $	��213��6]   5      �� 5   
   $��248,0,304.333,-0.333q�6   .+�5      �� -   5         ��Name$ dataGrid��5   A   $	��400��64   $��0,0,-118.667,0q�6S   $
��Left=�6k   $	��350��6�   ��6   �� *Menus+��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   $	��200 �63   �� 5   "   $	��100 �63   .+�5"      ��  ��Name$ 
txtProduct��6(   $��0��6<   ��6L   �� *Name+�� 5#      $��1��6(   $��Center=�6O   ��68   �� *Price+6O   5%      5'      5)      5+      �� 5,   
   5.      �� 51   
   $��632,268,31.333,9.667q�6   .+�52      �� -   5        $ btnAdd��52      $	��120��6:   $��2��6F   ���#5d636f$	��Add��53   :   
�������$��46��6[   $
��Left=�54   %   �� 55      -   5        $ 	btnRemove��55   %   $��3��6   ���#5d636f$��Remove��56   ;   
�������$��49��6_   $��0,0,-2,0q�6k   59      5:      5;      