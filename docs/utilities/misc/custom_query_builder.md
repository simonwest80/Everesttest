---
title: Custom Query Builder
---
<script type="text/javascript" language="JavaScript1.2" src="{{site.utl_baseurl}}/misc/ehlpdhtm.js" x-save-method="compute-relative"></script><script type="text/javascript" language="JavaScript1.2">
<!-- 
if( typeof( kadovInitEffects ) != 'function' ) kadovInitEffects = new Function();if( typeof( kadovInitTrigger ) != 'function' ) kadovInitTrigger = new Function();if( typeof( kadovFilePopupInit ) != 'function' ) kadovFilePopupInit = new Function();if( typeof( kadovTextPopupInit ) != 'function' ) kadovTextPopupInit = new Function();
 //-->
</script>
# Custom Query Builder


The table(s)  that is added from the [**Everest Schema Information**]({{site.utl_baseurl}}/misc/query_builder_everest_schema_information.html) section  is displayed. You can see the respective field names and field types for  each table.


Fields can be selected for the query by checking the box beside to the  table name (header) or select only required fields by checking the individual  boxes beside to the field names.


Right-click options in the **Custom Query 
 Builder** section:


**Delete**
: Use this option to remove the table from the Custom  Query Builder section.


![]({{site.utl_baseurl}}/img/aqb_custom_query_builder_section_ut.gif)


**Figure: Advanced Query Builder - Custom Query  Builder Section**


To filter data, you can construct the query by linking tables.  You can link tables by creating a [join](javascript:BSSCPopup('{{site.utl_baseurl}}/misc/join.html');){:id="A1"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A1');
//--></script>  between the fields of multiple tables. In other words, you are establishing  a [relationship](javascript:BSSCPopup('{{site.utl_baseurl}}/misc/relationship.html');){:id="A2"}<script type="text/javascript" language="JavaScript1.2"><!--
kadovFilePopupInit('A2');
//--></script>  between the tables. This narrows the search for your query and retrieves  the output faster.


You can create a join by dragging a field from the field  list of one table to the equivalent field (a field of the same or compatible  data type containing similar data) in the field list of the other table.


To delete the join, right-click the join line and select  the **Delete link** option. You will  be prompted for confirmation. Click **Yes**  to delete the join.


When you place your pointer device on the join line, you  will see a tip showing the association between the fields.


To do this, right-click the join line and select the **Property** option. You will see the **Link Properties** dialog box.


![]({{site.utl_baseurl}}/img/aqb_link_properties_dialog_box_ut.gif)


**Figure: Link Properties Dialog Box**


The dialog box displays the association between the fields  of the selected tables. You can modify this by selecting a suitable operator  from the drop-down list.


Select the **Include all from 
 &lt;table name&gt;** check boxes to specify the Right Outer join,  Left Outer join or Full Outer join for your query.


{:.see_also}
See also
: [The Advanced  Query Builder Dialog Box]({{site.utl_baseurl}}/other-utilities/the-advanced-query-builder/the_query_builder_dialog_box.html)
