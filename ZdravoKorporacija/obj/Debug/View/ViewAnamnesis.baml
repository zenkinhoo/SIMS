   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bolnica.ViewBolnica.View  5   	        Bolnica.View.ViewAnamnesis   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Bolnica.View     5   	     � WindowStyle$  
ToolWindow=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � 
ResizeMode$ NoResize=�5   	   $��Segoe UI Black)�5   	   ���	#FFBBB6B6 � Title$ ViewAnamnesis��5   	   $	��450��6   $	��400��6,   .��5      �  � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $	��10* �6   �� 5      $
��0.5* �6   �� 5      $��2* �6   �� 5      $
��0.5* �6    � ColumnDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $	��10* �6   �� 5      $
��1.5* �6   .+�5   
   �� $��0��6   $��1��6   $��	Anamnesis��6-   $��Center=�6A   $��Center=�6^   $��Center=�6�   $��Center=�6�   $��20(�6�   $��0,0,10,0q�6�   6�   �� 5   
   -   5         ��Name$ ListAnamnesis��5   _   $��1��6v   $��1��6�   $��15(�6�   $��Center=�6�   ���	#FFDDDDDD$��5q�6�   ���	#FF4D4B4B$��Segoe UI Black)�6	  $��Center=�6&  ��6   �� *	Anamnesis+ �� SelectedItem 64   �� *SelectedAnamnesis+6M  �� 5    
   -   5        $��1��5!      $��3��6"   $��Close��60   $��18(�6@   $��Segoe UI Black)�6N   $��3q�6j   ���	#FF4D4B4B��5       �� *CloseWindowCommand+ �� Mode$ OneWay=�5$      5&      5'      