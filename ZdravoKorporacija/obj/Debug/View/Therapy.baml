   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	       Bolnica.View.Therapy   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	   -   5          � WindowStyle$  
ToolWindow=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   $��Segoe UI Black)�5   	   ���	#FFBBB6B6 � Title$ Therapy��5   	   $	��450��6   $	��600��6&   .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $
��0.5* �6   �� 5      $��2* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $��5* �6   �� 5      $��5* �6   �� 5      $
��0.5* �6   .+�5    
   �� $��0��6   $��1��6   $��Your Therapy��6-   $��Center=�6D   $��Center=�6a   $��Center=�6�   $��Center=�6�   $��20(�6�   $��0,0,10,0q�6�   6�   �� 5!   
   $��0��6   $��2��6   $��How And When To Use?��6-   $��Center=�6L   $��Center=�6i   $��Center=�6�   $��Center=�6�   $��20(�6�   $��10,0,0,0q�6�   6�   �� 5"   
   -   5         ��Name$ MedicineList��5"      $��1��6(   $��1��65   $��15(�6F   $��Center=�6T   ���	#FFDDDDDD$��5q�6�   ���	#FF4D4B4B$��Segoe UI Black)�6�   $��Center=�6�   $��0,0,20,0q�6�   6A  �� 5#   
   -   5        $ MedicineWhenToUseList��5#      $��1��61   $��2��6>   $��15(�6N   $��Center=�6\   ���	#FFDDDDDD$��5q�6�   ���	#FF4D4B4B$��Segoe UI Black)�6�   $��Center=�6�   $��20,0,0,0q�6  6  �� 5$   
   -   5        $��1��5$      $��3��6!   $��Close��6/   $��18(�6?   $��Segoe UI Black)�6M   $��3q�6i   ���	#FF4D4B4B$��0,0,20,0q�6�   6�   5&      5'      