   M S B A M L   `   `   `  ����F  BMemoryCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MemoryCardsMemoryCards  5          MemoryCards.TimerPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:MemoryCards     5      -   5          N� Title$  	TimerPage��5       N� ShowsNavigationUI .  $
��1280��6H   $	��960��6X    � 	Resources 5	         BoolToVisConverter��%   &	        �� 5
   
   6'   5       N� 
Background 5      �� 5   
     backgroundCardsBlue �� ImageSource# �  6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� -   5          CustomBorder#���  5      $	��450��6A   $	��250��6M   $��1��6Z   $��1��6g   .��5      � $	��250��6    5      �� 5      $��40 �6$   �� 5      $	��100 �6$   �� 5      $��35 �6$   .+�5!      ��   CustomTitle#���  6   $��0��6B   $��Compteur��6O   $��0q�6_   $��Center=�6j   $��Center=�6�   $��36(�6�   ��6�   Z� �� 5"      -   5         ��Name$ TimerTB��5"   s     
CustomText#���  6   $��1��6A    �� Padding$
 0,20q�6�   $��Center=�6�   $��Center=�6�   $��48(�6�   ��6N   �� 	 �� Path$	 TimeInProgress���6�   Z� �� 5#      -   5        
 ��Name$	
 btn��5#        CustomButton#���  6&   $��	Continuer��6M   $��0q�6a   $��2��6l   $��Center=�6y   $��Center=�6�   $	��250��6�   $��35��6�   $��50��61  y�6�   �� $	 EndTimer� �� 	Converter# [  61  5$      5%      5&      5'      