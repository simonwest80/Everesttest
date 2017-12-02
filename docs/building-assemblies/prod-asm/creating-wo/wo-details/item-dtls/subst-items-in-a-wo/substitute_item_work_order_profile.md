---
title: Substitute Item in a Work Order
---

# Substitute Item in a Work Order


The standard mix of materials and labor are defined in the **Input** tab of the **Item** (Assembly)  profile (path: **Inventory** >  **Items** > **Options** > **Edit** > **In 
 New Window &gt; Assembly** > **Input**  tab). This can be changed on the work order by using the **Substitute 
 Item** option (path: **Work****Order** profile > **Options**  > **Item** > **Substitute 
 Item**).


![]({{site.ba_baseurl}}/img/example.gif)  You  make furniture and normally need the services of 2 skilled carpenters  for 8 hours at $20 each to make an item. But for one order, you use 1  skilled carpenter for 8 hours at $20 and 1 apprentice for 15 hours at  $10. The apprentice is a substitute for the carpenter. This is called  changing the labor mix.


When you substitute an item, the new item is added as a new line item  in the Item Details Grid of the **Work 
 Order** profile. The **Substitute 
 of** column for this line item is automatically updated with the  item code of the item that is substituted.


![]({{site.ba_baseurl}}/img/example.gif)  If  Item 1 is substituted with Item 2, Item 2 is added as a new line item  and the **Substitute Of** column for  Item 2 will display Item 1.


{:.steps}
To substitute an item, do the following:

- In the **Work** **Order**  profile highlight the item that is to be substituted.
- From the **Work** **Order**  profile, select **Options** > **Item** > **Substitute****Item**. You will see the [**Substitute** **Item**  dialog box]({{site.ba_baseurl}}/prod-asm/creating-wo/wo-details/item-dtls/subst-items-in-a-wo/substitute_item_dialog_box.html).
- Select the  required items and click **OK**. The  item is substituted in the work order.



{:.see_also}
See also
: [Variance  Analysis]({{site.ba_baseurl}}/prod-asm/variance-analysis/variance_analysis_work_order_profile_browser_option_assembly.html)
