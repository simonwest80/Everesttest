---
title: Document Details
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.ba_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Document Details


**Created By**
: This field displays the name of the logged in user  by default. This is a display field and cannot be edited.


**Assigned By**
: This field displays the user code of the person  assigning the work order. The name of the logged in user is displayed  by default.


**Assigned To**
: This field displays the name of the user to whom  the work order has been assigned. This is a mandatory field.


**Main Order #**
: **Everest**  allows you to process work orders in parts if you do not want to build  the entire required output during one assembly run.
: When the first batch is assembled, **Everest** creates another work order to account for the remaining quantity  to be built. For the newly created work order, the main order is the original  work order based on which the current one is created.
: ![]({{site.ba_baseurl}}/img/example.gif)<font color="#000080" class="hcp3"> &nbsp;</font>You  may need to build 100 computers but due to a shortage of materials, you  want to build only 10 on the first assembly run. You create Work Order  # 10000 to build these 10 computers. When the next work order (work order  # 10020) is created for another 50 computers, work order # 10000 is it’s  main order.


**Back Order**
: If work orders are processed in parts, the work  order that is created based on the current work order is called the Back  Order.
: ![]({{site.ba_baseurl}}/img/example.gif)<font color="#000080" class="hcp3"> &nbsp;</font>In  the above example, the second work order (10020) is the back order for  work order # 10000.


**Loc/Sub-Loc**
: The **Loc/Sub-Loc**  field displays the location or sub-location for which the work order is  created. By default this field displays the logged in location or sub-location.  You can select another location/sub-location, if you are executing a work  order on behalf of another location/sub-location. You cannot change the  location/sub-location once you select the [**In 
 Process**](javascript:BSSCPopup('{{site.ba_baseurl}}/misc/in_process_wo_status_assembly_content.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  option.


![]({{site.ba_baseurl}}/img/lens.gif) [Locations  and Sub-Location]({{site.sc_chm}}/options/locations-and-sub-locations/locations_and_departments.html)


**Description**
: The **Description**  field (beside the **Loc/Sub-Loc**  field) displays the location/sub-location's description as entered in  the **Location**/**Sub-Location** profile (path: **File** >  **Setup** > **Accounting**  > **Location/Sub-Location**>  **Options** > **Edit**  > **In New Window** > **General** tab > **Description** field). This is a display field and cannot be edited.


**Assigned Date**
: This field displays the date on which the work order  was assigned. The date displayed in this field is the login date.


**Build Date**
: This field displays the date on which the details  of the quantities built are entered. The date displayed in this field  is the login date (when the work order was built). This is a display field  and cannot be edited.


**Build<font style="color: #ff0000;" color="#FF0000"> </font>By**
: This field displays the name of the user who is  responsible for the production batch. This field is updated with the name  of the user specified in the **Build by**  field of the **Build** dialog box.  This field cannot be edited.


**Actual Output**
: The total output (sum of normal output and defectives)  is displayed in this field. This field is updated when the work order  is built and cannot be edited.


{:.see_also}
See also
: [Document  Tab View Information]({{site.ba_baseurl}}/prod-asm/creating-wo/wo-details/document_tab_view_information.html)
