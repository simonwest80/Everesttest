---
title: Separate Pick Ticket Based on Packing Type
---


This option allows you to indicate the number of pick tickets that have  to be generated based on the packing type (bulk or otherwise).


**One for all bulk items and one for all piece  items in the SO**
: Select this option to generate a separate pick ticket  for all bulk item contained in the sales order. If you select this option,  one pick ticket is generated for all the piece items contained in the  sales order and one for all bulk items.
: ![]({{site.sp_baseurl}}/img/example.gif) There  are two bulk items and 3 piece items on a sales order. If you select this  option two pick tickets are generated.
: ![]({{site.sp_baseurl}}/img/lens.gif) [Bulk Items](JavaScript:RelatedTopics1.Click())<!--Metadata type="DesignerControl" startspan
<object CLASSID="clsid:ADB880A6-D8FF-11CF-9377-00AA003B7A11"
	ID=RelatedTopics1
	TYPE="application/x-oleobject">
</object>-->

<object classid="clsid:ADB880A6-D8FF-11CF-9377-00AA003B7A11" id="RelatedTopics1" type="application/x-oleobject"> 
 <param name="Command" value="Related Topics">
<param name="Window" value="second">
<param name="Item1" value="Bulk Items;{{site.mi_chm}}/item-profile-details/other-items-information/sales/bulk_item_item_profile_contents.html">
</object><!--Metadata type="DesignerControl" endspan-->


**One for each bulk item and one for all piece  items in the SO**
: Select this option to generate a separate pick ticket  for each bulk item contained in the sales order. If you select this option,  one pick ticket is generated for all the piece items contained in the  sales order and one for each bulk item.
: ![]({{site.sp_baseurl}}/img/example.gif) There  are two bulk items and 3 piece items on a sales order. If you select this  option three pick tickets are generated.
