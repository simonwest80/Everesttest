---
title: Assembly Information
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.ba_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Assembly Information


Assembly information for a work order are listed below:


**Assembly**
: This field allows you to select the assembly item  to be manufactured. All items of type 'Assembly' are available for selection.  You cannot edit this field once you change the work order's status to  **In Process**, or enter quantities  in the **Actual Input** field.
: ![]({{site.ba_baseurl}}/img/lens.gif) [Assembly  Items]({{site.mi_chm}}/item-profile-details/item-types/assembly/assembly.html)


**Description**
: This field (beside the **Assembly**  field) displays the description of the assembly item as entered in the  **Item** (Assembly) profile (path:  **Inventory** > **Items**  > **Options** > **Edit** > **In New Window** >  **General** tab > **Description**  field). You cannot edit this field.


**Unit Of Measure**
: This field displays the stock unit of measure as  specified in the **Item** (Assembly)  profile (path: **Inventory &gt; Items &gt; 
 Options &gt; Edit &gt; In New Window &gt; Inventory** tab **&gt; Stock Measure** field). The Bill of Material is set up for the  manufacture of the assembly item in the stock measure. You cannot edit  this field.
: ![]({{site.ba_baseurl}}/img/lens.gif) [Measures]({{site.mi_chm}}/item-profile-details/measure/measure.html)


**Inventory Type**
: This field displays the inventory type of the item  selected in the **Assembly** field.  The item could be inventoried, inventoried - serialized or inventoried  - auto serialized. You cannot edit this field.
: ![]({{site.ba_baseurl}}/img/lens.gif) [Inventory  Type]({{site.mi_chm}}/item-profile-details/inventory-type/inventory_and_item_types.html)


**Created Date**
: This field displays the date on which the work order  was originally created. The date displayed in this field is the database  server date (when the work order was created) and not the login date.  You cannot edit this field.


**Required Date**
: This field displays the date by which the work order  should be completed. You cannot edit/modify this field once you select  the [**In Process**](javascript:BSSCPopup('{{site.ba_baseurl}}/misc/in_process_wo_status_assembly_content.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  option.


**Required Output**
: This field displays the number of units of the item  required to be manufactured. You cannot edit this field once you select  the [**In Process**](javascript:BSSCPopup('{{site.ba_baseurl}}/misc/in_process_wo_status_assembly_content.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  option.


**Quantity to be Built**
: This field allows you to enter the quantity that  is being built during the current production run.
: ![]({{site.ba_baseurl}}/img/example.gif)  You  need to build 100 computers during the first quarter of 2003. Since you  normally ship consignments of 10 to your customers, create a master work  order for the 100 units and enter 10 in the Qty to be built field.


{:.see_also}
See also
: [Work  Order Details]({{site.ba_baseurl}}/prod-asm/creating-wo/wo-details/contents_of_the_work_order_content_building_assembly.html)
: [The  Work Order Profile]({{site.ba_baseurl}}/prod-asm/creating-wo/create-a-work-order/the_work_order_profile_assembly_step_by_step.html)
