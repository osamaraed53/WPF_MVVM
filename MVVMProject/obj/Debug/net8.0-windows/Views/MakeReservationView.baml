   M S B A M L   `   `   `  ����F  BMVVMProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:MVVMProject.ViewsMVVMProject.Views  5      K*clr-namespace:MVVMProject.Views.ComponentsMVVMProject.Views.Components  5      =#clr-namespace:MVVMProject.ConverterMVVMProject.Converter  5      P LLoadingSpinnerControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null\Bclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControlLoadingSpinnerControl 5	      +    %MVVMProject.Views.MakeReservationView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:MVVMProject.Views     5      A
Components*clr-namespace:MVVMProject.Views.Components     5      9	converter#clr-namespace:MVVMProject.Converter     5      UcustomBclr-namespace:LoadingSpinnerControl;assembly=LoadingSpinnerControl     5	        � 	Resources  5      2   ,MVVMProject.Converter.ConverterForVisbiltyOf   converterforisloading��%   &	          5   
   6+   5      .��5      ��  �� Orientation$ Vertical=�6   $��Center=�6(   $��Center=�6E   .+�5   
   *  $LoadingSpinnerControl.LoadingSpinner     Diameter$	 100Q�5      
����+��   	Thickness$ 6Q�5      y�5      �� *	IsLoading+5      � 5   
    � IsSharedSizeScope$
 True��6   y�6-   �� *	IsLoading+ �� 	Converter# [   � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5"   
   �� $��Make Reservation��6   $��15(�5#      $
��Bold"�5$      $��0��5%      3   -MVVMProject.Views.Components.TextBoxWithLabel  5&   
      	LabelText$
 Name��6&   $
��Left=�67   $��1��5(   &   $	��225��63      TextBoxText 5'   &   �� *
Username+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�5(   3   �� 5*   
   $ 
Horizontal=�6   $��2��6.   $��0 25 0 0q�6;   .+�5+        $ 	Floor No.��6*   $	��100��5-   *    5,   *   �� *FloorNumber+$	 TwoWay=�$
 PropertyChanged=�5-   *     5/      $ Room No.��6*   $	��100��51   *   $��25 0 0 0q�52   *    50   *   �� *
RoomNumber+$	 TwoWay=�$
 PropertyChanged=�52   *   53      � 56   
   $��3��6   $
��0 25q�6    � ColumnDefinitions 57      �� 58      $
��auto �6#   �� 59      $��25 �6#   �� 5:      $
��auto �6#    5<      �� 5=      $
��auto �6     z� SharedSizeGroup$ A��6/   �� 5>      $
��auto �6    $ B��6/   .+�5A      �� $��
Start Date��6   $��0��6*   $��0��6:   �� 5B      $��End Date��6   $��2��6(   $��0��68   (  "System.Windows.Controls.DatePicker  5D      $	��100��6   $��0��5E      $��1��5F         SelectedDate 5G      �� *	EndDate+$	 OneWay=�$
 PropertyChanged=�  5H      $	��100��6   $��2��5I      $��1��5J       5K      �� *	StartDate+$	 OneWay=�$
 PropertyChanged=�5L      �� 5N   
   $ 
Horizontal=�6   $��4��6.   .+�5O      �� $��Submit��6   $	��100��6H   ��6&   �� *SubmitCommand+6H   �� 5P      $��Cancel��6   $��25 0 0 0q�5Q      $	��100��5R      ��5P   &   �� *%#NavigateToReservationListingCommand+5R      5S      5U      5V      5W      