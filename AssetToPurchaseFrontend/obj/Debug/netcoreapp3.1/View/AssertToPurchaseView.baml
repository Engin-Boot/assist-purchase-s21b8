   M S B A M L   `   `   `  ����R  NAssetToPurchaseFrontend, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:AssetToPurchaseFrontend.ViewModel!AssetToPurchaseFrontend.ViewModel  5      7    1AssetToPurchaseFrontend.View.AssertToPurchaseView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      E	viewmodel/clr-namespace:AssetToPurchaseFrontend.ViewModel     5        � 	Resources  5	      @   :AssetToPurchaseFrontend.ViewModel.AssetToPurchaseviewModel   Vm��%   &	          5
   
   6-   5      .��5      ]� $
��True��6   
�������.+�5   
   �� $��2q�6   $��50��6'   $	��Top=�64   ._�5      �� $��Center=�6   $��Center=�65   $��20(�6P   
����� �Asset Purchase ChatBot6�   5      �� 5   
   $��2q�6   $��50��6&   $��Bottom=�63   ._�5      �� 
����� �$��Center=�62   $��Center=�6O   $��20(�6j   
@Philips6�   5      �� 5   
   $��2q�6   $	��250��6&   $��Right=�63   ._�5      �� .+�5      �� $��20(�6   $��Center=�6+   $��Center=�6H   
����� �Registration And Ordering6�   � 5      $��Center=�6   $��Center=�64   $��10q�6O    � RowDefinitions 5      �� 5      $��* �6(   65   �� 5      $��* �6(   65   �� 5      $��* �6(   65   �� 5      $��* �6(   65   �� 5      $��* �6(   65    � ColumnDefinitions 5      �� 5      $
��auto �6+   6:   �� 5       $
��auto �6+   6:   +�5"      �� 5#      $��2q�6$   $	��100��6/   $��25��6;   $��0��6G   $��0��6T   Name6j   �� 5$      $��2q�6$   $	��100��60   $��25��6<   $��1��6I   $��0��6V   Email6m   �� 5%      $��2q�6$   $	��100��60   $��25��6<   $��2��6H   $��0��6U   Model6l   �� 5&      $��2q�6$   $	��100��6/   $��25��6;   $��3��6G   $��0��6T   Contact Number6t   �� 5(      $��2q�6T   $	��100��6_   $��0��6k   $��1��6x   ��6"   �� *Name+ �� Source# [  6�   �� 5)      $��2q�6W   $	��100��6b   $��1��6n   $��1��6{   ��6"   �� *Email+# [  6�   �� 5*      $	��100��6�   $��2��6�   $��1��6�    �� SelectedValue 6#   �� *ModelTypeSelected+# [  ��6k   �� *	ModelType+# [  6�   �� 5+      $��2q�6^   $	��100��6i   $��3��6u   $��1��6�   ��6"   �� *ContactNumber+# [  6�   �� 5-      $	��120��6m   $��30��6z   $��4��6�   $��0��6�   $��Register/OrderConfirmed��6�   ��6!   �� *RegisterAndOrderingCommand+# [  6�   �� 5.      $	��100��6j   $��30��6v   $��4��6�   $��1��6�   $��Clear��6�   ��6!   �� *ClearCommandRegistration+# [  6�   50      51      52      �� 54   
   $��2q�6   
�������6;   � 56   
   $��0,0.8,0,-20q�6    57      �� 58      $��* �6    6-   �� 59      $��* �6    6-   .+�5=      �� $
��Auto=�6   $
��Auto=�5>      $
��True��5?      $��Stretch=�5@      $��5,5,5.2,95.4q�5A      $��Stretch=�5C      $
��Auto��62    �� 
IsReadOnly$
 True��6?   $��0��6Q   $��2��6^   ��5B      �� *
ChatArea+# [   �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=�5C   ^   �� 5F      $
��Left=�6   $��84��63   $��1��6>   $
��Wrap=�6K   $��Your message:��6_   $	��Top=�6t   $��13,99.2,0,0q�6�   �� 5G      $��Stretch=�6O   $
��Auto��6k   $��1��6x   $��25,118.8,96.2,10.4q�6�   ��6   �� *YourMessage+# [  6�   �� 5I      $
��Send��6Q   $
��Left=�6`   $��1��6|   $	��Top=�6�   $��75��6�   $��457,114.8,0,0q�6�   $��20��6�   ��6   �� *SendCommand+# [  6�   �� 5J      $��Clear��6R   $
��Left=�6b   $��1��6~   $	��Top=�6�   $��75��6�   $��457,144.8,0,0q�6�   $��20��6�   ��6   �� *ClearCommand+# [  6�   5N      5P      5Q      