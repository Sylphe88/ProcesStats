   M S B A M L   `   `   `  ����  ProcessInfo#    ProcessInformation.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  window��5   	    � Title$ Processes Information��5   	   $	��350��6'   $	��488��64   $	��400��6@   $	��300��6O    � DataContext 5   	   ��  �� Mode$ OneWay=� �� RelativeSource �� *Self+.��5      �  � ColumnDefinitions 5   
   �� 5      �� 5	      $��5 �6    � RowDefinitions 5   
   �� 5      �� 5      $��5 �6   �� 5      $��26 �6   .+�5   
   �� -   5         ��Name$ Total��5      $��2��6   $��0��6,   $��Right=�6<   $	��100��6X   $��Right=�6g   $��Italic$�6�   ��6�   �� *	ProcCount+6�   �� 5   
   $��0��6   $��1��6$    �� ResizeDirection$ Columns=�64   	 �� ResizeBehavior$	 PreviousAndCurrent=�6N   
 �� DragIncrement$
 10Q�6r   �� 5   
   $��1��6   $��0��6$   $
 Rows=�64   $	 PreviousAndCurrent=�6K   $
 10Q�6o   �� 5   
   -   5         ��Name$ ProcessesInfo��5      $��0��6)   $��0��66   $
��Auto��6F   $��	10,10,0,0q�6T      ProcessInfoDisplay#���   6g   $��Stretch=�6�    �� SelectionMode$ Extended=�6�   $	��455��6�   $
��Left=�6  $	��Top=�6&  $	��400��6>  $	��250��6M  ��6�   ��  �� Path$ pDisplay� � 	Resources 5      ��%�  &	        �� 5      .R�5      � $��1q�6    5      �� 5      $	��150 �6/   �� 5      $��50 �6/   �� 5      $��* �6/   .+�5      �� $��0��6    $��26��60   $	��Top=�6^   ��6<   �� $ ProcName�6^   �� 5      $��1��6    $��26��60   ��6<   �� $ ID��� 5      $��2��6    $��26��60   ��6<   �� $ RunTime�5      5       5!      5"      5$      5%      