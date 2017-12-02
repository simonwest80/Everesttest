---
title: The Specify Filter Dialog Box
---

# The Specify Filter Dialog Box


This dialog box consists of the **Filter 
 (Display) Panel**.


**Specify Filter - Filter (Display) Panel**
: This panel enables you to build a find condition,  using the available parameters. The options available in the **Specify 
 Filter** dialog box are:


**OK**
: Select this option when you have finished defining  the condition, and want to save it. The **Filter 
 Name** dialog box is displayed, which enables you to specify a name  for the newly created **Classic Style**  filter, and save it.


**Cancel**
: Select this option to close the **Specify 
 Filter** dialog box.


{:.example}
To filter the **Items** browser  for items with available stock less than 5, you must define the following  condition, by selecting the required parameters:


BrwCol.AVAILABLE  less than 5


The query is displayed in the **Filter 
 (Display) Panel**. Click **OK**  to save the condition. The **Filter Name**  dialog box is displayed. Specify a name for the newly created **Classic 
 Style** filter, and click **OK**.  You will see the **Filters** dialog  box. Click **Apply** to run the filter.


The **Items** browser displays only  those items with available stock less than 5.


![]({{site.wwe_baseurl}}/img/note.gif)


Only the records displayed in the browser  are filtered. To filter all the records using the specified  criteria,  you must first display all the records in the browser, by using the **Get All** option.


The following message is displayed above the browser’s status bar:


![]({{site.wwe_baseurl}}/img/stock less than 5.bmp)


To further filter the records in the browser, or modify the filter,  double-click the filter details and define additional conditions in the  **Filter (Display) Panel**. Click  ![]({{site.wwe_baseurl}}/img/x.bmp)  to  clear the filter that has been applied to the browser.


{:.steps}
To define the above mentioned condition,  do the following:

- From the main  menu, select **Inventory &gt; Items**.  You will see the **Items** browser.
- Click the **Expert Style Filter** ![]({{site.wwe_baseurl}}/img/wwe_standard_browser_options_expert_style_filter.gif) icon.  You will see the **Filters** dialog  box.
- Click the drop-down  arrow beside the **Add** button. Select  **Classic Style** from the drop-down  list.
- You will see  the **Specify Filter** dialog box.
- In the display  panel, click . You will see the following parameter: ‘BrwCol.ITEMNO  contains <?>’.
- Click ‘BrwCol.ITEMNO’.  From the drop-down list, select ‘BrwCol.AVAILABLE’.
- Click ‘contains’.  From the drop-down list, select ‘less than’.
- Click ‘<?>’.  Enter ‘5’ in the text box.
- Click **OK**. You will see the **Filter 
 Name** dialog box.
- Specify a name  for the newly created **Classic Style**  filter, and click **OK**.
- You will see  the **Filters** dialog box. Click  **Apply** to run the filter.
- The browser  lists records that meet the selection criteria specified.



Similarly, you can add more parameters to the **Classic 
 Style** condition statement, to narrow your search.


{:.see_also}
See also
: [Filter  Records using the Classic Style Filter]({{site.wwe_baseurl}}/misc/filter_records_using_the_classic_style_filter.html)
