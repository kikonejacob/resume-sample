   M S B A M L   `   `   `  ����A  =resume, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:resume.Viewresume.View  5   	   3clr-namespace:resume.ViewModelresume.ViewModel  5   	       resume.View.EditResume   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:resume.View     5   	   -vmclr-namespace:resume.ViewModel     5   	     � Title$  
EditResume��5	   	   $��810.422��6   $��605.07��6-    � DataContext 5
      &   resume.ViewModel.ResumeViewModel  5   
   .��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��	0,0,-6,-2q�6+   z�5   
   V� 5      .~�5      �� �� 5      �� 5       �� Angle$
 0.58Q�6"   T� 5      5      .+�5   
   ��  �� Orientation$ Vertical=�6    6,   ��  �� Path$ CurrentResume� �� Mode$ TwoWay=�.+�5      �� $ Vertical=�6   .+�5      �� $ 
Horizontal=�6   $��4q�66   .+�5      �� $��
First Name��6   $
��Left=�61   $��0,0,4,0q�6M   $	��Top=�6^   $��81��6v   �� 5      $	��230��6   ��6+   �� *PersonalInfo.FirstName+5      �� 5      $ 
Horizontal=�6   .+�5      �� $��	Last Name��6   $
��Left=�60   $��0,0,8,0q�6L   $	��Top=�6]   $��81��6u   �� 5      $	��230��6   ��6*   �� *PersonalInfo.LastName+5      �� 5       $ 
Horizontal=�6   .+�5!      �� $��
Birth date��6   $
��Left=�61   $��0,0,8,0q�6M   $	��Top=�6^   $��81��6v   (  "System.Windows.Controls.DatePicker  5"      $	��230��6"   5#      5%      5'      �� 5(   
   .+�5)      &   System.Windows.Controls.DataGrid  $
��Left=�6   $	��137��62   $��
27,138,0,0q�6?   $	��Top=�6S   $	��522��6k   ��6w   �� *CurrentResume.Educations+�� 5*      $��
Education:��6   $
��Left=�6)   $��26��6D   $��
27,107,0,0q�6P   $	��Top=�6d   $��81��6|   5+      �� 5,   
   .+�5-        $
��Left=�6   $	��170��62   $��
27,330,0,0q�6?   $	��Top=�6S   $	��522��6k   ��6w   �� *CurrentResume.WorkHistories+�� 5.      $��Work history:��6   $
��Left=�6,   $��26��6G   $��
27,299,0,0q�6S   $	��Top=�6g   $��81��6   5/      �� 50   
   .+�51        $
��Left=�6   $	��143��62   $��
27,541,0,0q�6?   $	��Top=�6S   $	��522��6k   ��6w   �� *CurrentResume.Certifications+�� 52      $��Certifications��6   $
��Left=�6-   $��23��6H   $��
27,513,0,0q�6T   $	��Top=�6h   $	��105��6�   54      �� 57      $
��Save��6   $
��Left=�6!   $��27��6<   $��459,701,0,0q�6H   $	��Top=�6]   $��90��6u   ��6�   �� *SaveCommand+�� 58   
   -   5        $��Cancel��58      $
��Left=�6"   $��27��6=   $��333,701,0,0q�6I   $	��Top=�6^   $��94��6v   6�   5:      5;      