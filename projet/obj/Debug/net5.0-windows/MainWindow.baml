   M S B A M L   `   `   `  ����A  =projet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:projetprojet  5   	   ;"clr-namespace:projet.MVM.ViewWodelprojet.MVM.ViewWodel  5   	       projet.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:projet     5   	   8	viewWodel"clr-namespace:projet.MVM.ViewWodel     5   	   -   5          � Title$  
MainWindow��5	   	   $	��680��6   $	��920��6)    � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�5   	   
������  � AllowsTransparency$
 True��5   	    � DataContext 5      (   "projet.MVM.ViewWodel.MainViewModel  5   
   .��5      �� ���#34ebeb._�5   
   �  � ColumnDefinitions 5      �� 5      $	��200 �6#   �� 5       � RowDefinitions 5      �� 5      $��75 �6    �� 5      .+�5      �� -   5        $��titre��5   +   $��Weather Map��6   $��Center=�68   $��Center=�6S   
���   �$��22(�6�   $��20,0,0,0q�6�   �� 5      -   5        $
��menu��5   &   $��1��6   .+�5      	� -   5        $
��home��5      $	��Map��6+   $��50��69   
���   �$��14(�6X      MenuButtonTheme#��[  6f    d� 	IsChecked$
 TrueY�6�    � Cursor$
 Hand��6�   ��6�   �� *HomeViewComand+6�   	� 5      -   5        $
��city��5      $��Toulouse��6+   $��50��6>   
���   �$��14(�6]   #��[  6k   $
 Hand��6�   ��6�   �� *CityViewComand+6�   5      �� 5       -   5        $��	searchbar��5       $	��400��6(   $��40��64   $��Center=�6@   $��Center=�6[   $��5q�6x   $��1��6�     SearchbarTheme#��[ 6�   �� 5!      -   5        $��1��5!      $��30��6%   $��30��60   
���**��$��0q�6O   
���   �$
��Bold"�6v   $��Right=�6�   $	��Top=�6�   $	��⨉��6�   $
 Hand��6�   �� 5"      -   5        $��1��5"      $��20��6%   $��20��60   
������ $��0q�6U   
�������$
��Bold"�6|   $��Go to location��6�   $
 Hand��6�   ��6�   �� *CityViewComand+6�   �� 5$      $��1��6   $��1��6-   $��10q�6:   ��6F   �� *CurrentView+5&      5(      5)      