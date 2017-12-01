---
title: Create an Advanced Query Builder Dashboard Filter
---

# Create an Advanced Query Builder Dashboard Filter


Advanced users with knowledge of Microsoft SQL can create  custom Advanced Query Builder filters directly on the **Everest 
 Advanced Dashboard** without using the Advanced Query Builder utility  in **Everest**. This can be very helpful  if your business requires more information than is available from the  **Everest** standard filters. Since  the Advanced Filter Web Parts on the dashboard are “read only”, advanced  filters created on the dashboard are not added to the Advanced Query Builder  filters in **Everest**.


{:.note}
If you want to create an Advanced Query Builder  filter that can be used in **Everest**  or on the dashboard, first create the filter in the Advanced Query Builder  Utility (path: **Utility** > **Advanced Query Builder**), and then add  the filter to the dashboard using the “Add an Advanced Query Builder Filter  Web Part” procedure.


{:.steps}
To create an Advanced Query Builder filter  on the Everest Advanced Dashboard using Microsoft SQL, do the following:

- On the top right  side of the Dashboard, click the down arrow following **Site 
 Actions**.
- Select **Edit 
 Page**. The Dashboard displays in Edit mode.
- In the dashboard  location where you would like the new web part added (Header, Left Column,  Middle Column, Right Column, or Footer), click **Add 
 a Web Part**. The **Add Web Parts**  dialog box displays for the dashboard location selected.
- Select **Everest 
 Advanced Filter** from the All Web Parts list.
- Click the **Add** button. The **Everest 
 Advanced Filter** web part is added to your dashboard. The number  in brackets indicates if there is more than one Advanced Query Builder  filter web part on the dashboard. You still need to link to the filter  content.



![]({{site.db_baseurl}}/img/create_aqb_web_part_1_ead.gif)


**Figure: New Advanced Query Builder Web Part Added**

- Click the drop  down arrow following **edit** and  select **Modify Shared Web Part**.  A dotted line appears around the new **Everest 
 Advanced Filter** web part indicating that it is in Edit Mode and  the dialog box for the selected web part is displayed.
- Verify that **&lt;Custom SQL&gt;** is selected in the  **Filter** drop-down list.
- Enter your SQL  in the **Custom SQL** field.
- In the **Appearance**  section, enter a title for your Advanced Query Builder filter.



In the figure below, the following SQL was added to the Custom  SQL field:
: select top 20 xp.qty\_rec Qty,
: i.itemno  Item,
: i.Descript  Descrption,
: p.doc\_no  Document,
: p.order\_date  Date
: from
: po  p (nolock),
: x\_po  xp (nolock),
: items  i (nolock)
: where
: p.status=24  and p.order\_no=xp.order\_no
: and  p.status=xp.status
: and  xp.item\_code=i.itemno
: order by
: p.order\_date  desc,
: p.order\_no  desc


This advanced filter displays a list of the product just  received into inventory.


![]({{site.db_baseurl}}/img/create_aqb_web_part2_products_just_arrived_ead.gif)


**Figure: Everest Advanced Filter Dialog Box with  SQL and Title Added**


{:.hint}
In the **Everest 
 Advanced Filter** dialog box **Layout**  section, select **Hidden** to keep  your new Advanced Query Builder web part off the dashboard until you are  finished adjusting it.

- Click **Apply**.
- Click **OK**  to save the changes and close the dialog box. The new name displays on  the web part.
- Click the **Exit Edit Mode** link in the top right  corner of the dashboard to exit edit mode. The new Advanced Query Builder  Web Part displays on the dashboard.



![]({{site.db_baseurl}}/img/create_aqb_web_part3_products_just_arrived_ead.gif)


**Figure: Everest Advanced Filter “Products Just  Arrived” created with SQL from the Dashboard**


{:.note}
If you see the “Error occurred while fetching  the query  results”  error message in your web part, you will need to adjust your SQL to view  the required results.


{:.see_also}
See also
: [Modify  an Advanced Query Builder Web Part]({{site.db_baseurl}}/working-with-the-everest-web-part-wizard/modify_an_advanced_query_builder_web_part_ead.html)
