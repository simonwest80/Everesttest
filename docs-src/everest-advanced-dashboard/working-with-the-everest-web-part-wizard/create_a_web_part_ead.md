---
title: Create a Web Part
---

# Create a Web Part


Use the **Everest Advanced Dashboard**  site default web parts to get your dashboard site up and running quickly.  With the appropriate administrative rights, you can create your own web  parts according to your business needs.


{:.note}
The following procedure for creating a web  part does not discuss all of the available options. Click the **Help**  button at any time to view detailed information on the **Web 
 Part Wizard** screens and information on options not discussed in  this procedure.


{:.steps}
To create a Web Part, do the following:

- On the top right  side of the Dashboard, click the down arrow following **Modify 
 Shared Page**.
- Select **Add 
 Web Parts &gt; Browse**. The **Add 
 Web Parts – Browse** dialog box is displayed.



Add Web Parts - Browse Dialog Box

- Select **Virtual 
 Server Gallery**.
- In the **Web 
 Part List**, select one of the following:


- **Everest Chart**  – Displays data as a chart
- **Everest Filter**  – Creates a web part filter
- **Everest Table**  – Displays data in table format
- **Everest Trend**  – Shows changes in measures over time (Uses two comparable measures)
- **Everest ZGraph**  – Displays three values of two measures over time


- Drag the selected  web part to an open space on the dashboard. You have more control over  where the web part is placed if you use drag and drop.



**OR**

- In the **Add 
 to** field at the bottom of the dialog box, select the location (Header,  Left Column, Middle Column, Right Column or Footer) for the new web part  on the dashboard. Click the **Add**  button.  The  web part is added to the dashboard.



**![]({{site.db_baseurl}}/img/ead create web part configure no dsp.gif)**


**New Web Part to be Configured**

- In the new web  part, click the **Click here to configure 
 this web part** link. A dotted line is displayed around the web part  indicating that it is in Edit Mode and the **Open 
 Wizard** button is available in the selected web part dialog box.



![]({{site.db_baseurl}}/img/ead new web part in edit mode.gif)


**New Web Part in Edit Mode**


**![]({{site.db_baseurl}}/img/ead create web part - web part dialog box example.gif)**


**Web Part Dialog Box Example**

- Click the **Open Wizard** button. The **Everest****Web Part Wizard – Welcome** screen  is displayed.



Everest Web Part Wizard - Welcome Screen

- On the **Welcome**  screen, specify an available sub type, such as Gauge.



{:.note}
You can click a web part sub type and view  a preview of that web part sub type to the right.

- Click **Next**.  The **Data Source** screen is displayed.



Everest Web Part Wizard - Data Source Screen

- On the **Data 
 Source** screen, click the **Server**  tab.
- Click **Next**.  The **Measures** screen is displayed.



Everest Web Part Wizard - Measures Screen

- On the Measures  screen **Measures** tab, choose one  or more measures for your web part depending upon the web part type that  you selected. Alternatively, on the **Expressions**  tab, you can choose an expression for your web part.
- Click **Add**  to add the measure(s) or expression to the **Selected 
 Measures** section.
- Click **Next**.  The **Dimensions** screen is displayed.



Everest Web Part Wizard - Dimensions Screen

- On the **Dimensions**  screen, in the **Available Dimensions**  field, select an available dimension for your web part. The **Dimension**  provides the context for the sales measure in the data warehouse data  mart. It is a way of viewing the sales information in your web part.
- In the **Level**  field, select the level of detail to use for your dimension.
- On the **Members**  tab, select the members to be included in the dimension.
- Select **Lock 
 Dimension from Selection** if you do not want members in this dimension  to be used to filter data. This option is not available if you select  **All** members on the **Members**  tab.
- Click **Add** to move the selected members to the **Selected Dimensions** section.
- If your selected  dimension is on the filter axis, you can select **Don’t 
 Display Selection** to hide the selected dimensions.
- Select **Add 
 Sub Total** **for Selected Members**  to display subtotals on your web part.
- Click **Next**.  The **Layout** screen is displayed.



Everest Web Part Wizard - Layout Screen

- On the **Layout**  screen, accept the defaults or select your layout details. The choices  available to you depend upon the web part type selected.
- Click **Preview**  to preview your web part. Make any necessary changes.
- Click **Next**.  The **General Settings for the Web Part**  screen displays.



Everest Web Part Wizard - General Settings for the  Web Part Screen

- On the **General 
 Settings for the Web Part** screen, accept the default setting, **Enable Detail** Link, to have your web  part open an Analysis Services pivot table.



{:.note}
End users will need an OLAP client such as  MS Office Web Components (OWC) or ProClarity and Executive Viewer to take  advantage of this link. A free OWC OLAP client is available on the Microsoft  web site.

- If you would rather  have the link open a URL, enter the information on this screen.


- Click **Next**.  The **Publish Web Part** screen is  displayed.



Everest Web Part Wizard - Publish Web Part Screen

- Click **Publish**  to publish your web part.



Web Part Dialog Box

- At the bottom of  the web part type dialog box, click **Apply**  and then click **OK**. The new web  part is now configured on your dashboard. To rename the web part, follow  the **Rename a Web Part** procedure.



**![]({{site.db_baseurl}}/img/ead create web part new part on dashboard no dsp.gif)**


**New Web Part Added to Dashboard**


{:.see_also}
See also
: [Rename a Web  Part]({{site.db_baseurl}}/working-with-the-everest-web-part-wizard/rename_a_web_part_ead.html)
