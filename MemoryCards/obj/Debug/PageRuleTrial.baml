   M S B A M L   `   `   `  ����F  BMemoryCards, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MemoryCardsMemoryCards  5          MemoryCards.PageRuleTrial   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:MemoryCards     5        N� Title$  PageRuleTrial��5       N� ShowsNavigationUI .  $
��1280��67   $	��960��6G    N� 
Background 5	      �� 5
   
      backgroundCardsBlue �� ImageSource# �   6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      $	��800 �6   �� 5       � RowDefinitions 5   
   �� 5      �� 5      $
��Auto �6   �� 5      .+�5   
   �� $��1��6   $��1��6&     CustomBorder#���  66   |�.  ��.  .��5      �  5      �� 5      $��70 �6$   �� 5      $
��Auto �6$   �� 5      $��70 �6$   .+�5      ��   CustomTitle#���  6   $��0��6B   $��Régles du jeu��6O   $��Center=�6d   $��Center=�6�   $
��Bold"�6�   $��36(�6�     GeneralFont#���  6�   ��6�   Z� �� 5      $��1��6   .+�5       ��   
CustomText#���  6     �� Padding$
 20 0q�6E   $��Center=�6T   $��Center=�6q   $
��Wrap=�6�    �� TextAlignment$ Justify=�6�   #���  6�   $��18(�6�   $��0,20,0,0q�6�   ��Toutes les cartes sont étalées faces cachées sur le plateau. Le joueur retourne deux cartes. Si c'est la même image ou le même son qui apparaît sur les deux cartes, le joueur valide les cartes et en retourne à nouveau deux. Si les deux cartes ne vont pas ensemble, les cartes se remettent face cachée à l'endroit exact où elles étaient.5#      �� 5$      #���  6    $
 20 0q�6E   $
��Left=�6U   $��Center=�6p   $
��Wrap=�6�   $ Justify=�6�   #���  6�   $��18(�6�   $��0q�6�   ;9Une fois toutes les cartes trouvées l'essai est validé.5&      �� 5'      #���  6    $
 20 0q�6E   $
��Left=�6T   $��Center=�6o   $
��Wrap=�6�   $ Justify=�6�   #���  6�   $��18(�6�   $��0,0,0,20q�6�   ywQuand le joueur valide ses 6 essais la partie est terminée. Le 6ème essai laisse visible toutes les cartes trouvées.5)      5*      �� 5+      -   5          CustomButton#���  5+      $��Valider��6@   $��2��6R   $	��250��6v   $��35��6�   $��50��6�   5,      5-      5.      5/      