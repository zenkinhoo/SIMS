   M S B A M L   `   `   `  ����L  HZdravoKorporacija, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BolnicaBolnica  5   	   +    %Bolnica.SecretaryScheduleAppointments   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Bolnica     5   	     � Title$#  SecretaryScheduleAppointments��5   	   $	��450��6/   $	��800��6<   .��5	      � .+�5
   
   �� $��Appoinmtent for patient:��6   $
��Left=�63   $��	70,54,0,0q�6N   $	��Top=�6a   �� 5   
   -   5        $��dataPatient��5      $
��Left=�6%   $��23��6@   $��
259,57,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $�� ��6t   $	��Top=�6|   $	��120��6�   �� 5   
   $��Doctor:��6   $
��Left=�6"   $��
70,109,0,0q�6=   $	��Top=�6Q   �� 5   
   $��
datePoint:��6   $
��Left=�6%   $��
70,168,0,0q�6@   $	��Top=�6T   �� 5   
   $��	Priority:��6   $
��Left=�6$   $��
70,273,0,0q�6?   $	��Top=�6S   	� 5   
   -   5        $
��prvi��5   +    	� 	GroupName$ priority��6   $��Doctor��67   $
��Left=�6H   $��164,278,0,0q�6c   $	��Top=�6x   6�   	� 5   
   -   5        $��drugi��5   +   $ priority��6   $
��Time��68   $
��Left=�6G   $��269,278,0,0q�6b   $	��Top=�6w   6�   �� 5   
   $
��Left=�6   $
��Wrap=�6/   $��	TextBlock��6C   $	��Top=�6T   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��	startTime��5      $
��Left=�6&   $��164,170,0,0q�6A   $	��Top=�6V   �� 5   
   -   5        $��combo��5      $
��Left=�6    $��191,113,0,0q�6;   $	��Top=�6P   $	��343��6h   �� 5   
   -   5        $��slobodni termini��5      $
��Left=�6,   $��568,257,0,0q�6G   $	��Top=�6\   $	��151��6t   6�   �� 5   
   -   5        $��startTimeHours��5      $
��Left=�6)   $��23��6D   $��297,168,0,0q�6P   $
 Wrap=�6e   $��xx:xx:xx xx��6y   $	��Top=�6�   $	��120��6�   �� 5   
   -   5        $��endTimeHours��5      $
��Left=�6'   $��23��6B   $��297,210,0,0q�6N   $
 Wrap=�6c   $�� ��6w   $	��Top=�6   $	��120��6�   �� 5   
   -	   5        $��create appointment��5      $
��Left=�6.   $��568,308,0,0q�6I   $	��Top=�6^   $	��151��6v   6�   �� 5   
   $"��Radno vreme je od 1 do 7h PM��6   $
��Left=�67   $��
489,54,0,0q�6R   $	��Top=�6f   $	��251��6~   5      5      