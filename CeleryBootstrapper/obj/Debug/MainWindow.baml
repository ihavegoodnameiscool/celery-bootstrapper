   M S B A M L   `   `   `  ����M  ICeleryBootstrapper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:CeleryBootstrapperCeleryBootstrapper  5   	   #    CeleryBootstrapper.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:CeleryBootstrapper     5   	   -   5          � Title$  
MainWindow��5   	   $	��268��63   $	��492��6@    � WindowStyle$
 None=�6L    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�6�   .��5	      � $��-1,0,1,0q�6   .+�5
   
   �� -   5         ��Name$ hello��5
      $
��Left=�6   $	��133��6:   $��	22,27,0,0q�6G   $	��Top=�6Z   $	��122��6r   $��/CeleryLogo.png��6~    K� ZIndex$
 2000��6�   �� 5   
   -   5         ��Name$ welcome��5      $��
Welcome to��6!   $
��Left=�66   $��-214,27,0,0q�6Q   $	��Top=�6f   
�������$��25(�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��190��6�   $ 200000��6�   z�5      V� 5      .~�5      ��  �� ScaleX$ 1Q�6%   �� 5      �� 5      T� 5      5      5      �� 5   
   -   5        $ celery��5      $��Celery Bootstrapper��6    $
��Left=�6>   $��-287,65,0,0q�6Y   $	��Top=�6n   $��25(�6�   
��� � �$ 0.5,0.5&�6�   $	��249��6�   $ 2000000��6�   z�5      V� 5      .~�5      �� $ 1Q�6%   �� 5      �� 5      T� 5      5      5      � 5   
   -   5        	 �Name$	 installgrid��5      $��10,226,409,9q�6$   ���#242424$y�	Collapsed=�6q   $ 200000��6�   .+�5       �� -   5        $ installlabel��5       $��Install��6*   $
��Left=�6<   $��Center=�6W   $��73��6r   
�������$��14,0,0,0q�6�   5!      �� 5"   
   ���	#FF000000���#151515$	��0.5q�6>   
 �� CornerRadius$
 15��6T   $	 203��6f   ._�5#      � 5$      � 5%   
   -   5        $	 
updategrid��5%      $��103,227,317,8q�6#   ���#242424$y�	Collapsed=�6p   $ 200000��6�   .+�5&      �� -   5        $ updatelabel��5&      $��Update
��6)   $
��Left=�6D   $��11,0,0,0q�6_   $��Center=�6q   $��26��6�   
�������$��65��6�   5'      � 5(   
   -	   5        $	 
deletegrid��5(      $��192,227,228,8q�6#   ���#242424$y�	Collapsed=�6p   $ 199999��6�   .+�5)      �� -
   5        $ deletelabel��5)      $��Delete
��6)   $
��Left=�6?   $��14,0,0,0q�6Z   $��Center=�6l   $��26��6�   
�������$��58��6�   5*      �� 5+   
   -   5        $ Downloading��5+      $y�	Collapsed=�6%   $;��5                          Downloading Celery.zip...
��6<   $
��Left=�6�   $��	0,207,0,0q�6�   $	��Top=�6�   
�������$��20(�6�   $ 200000��6�   �� 5,   
   -   5        $	��❌��5,      $
��Left=�62   ���#151515$��	466,5,0,0q�6b   $	��Top=�6u   $��0q�6�   
���  ��$��20��6�   $ 20000��6�   5-      5.      