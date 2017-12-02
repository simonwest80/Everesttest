---
title: Back End Processes - Stock Transfer
---

# Back End Processes - Stock transfer


When you transfer stock, the stock status of the ‘from’ and  ‘to’ stock areas shows the following changes:

- Stock area from which  items are transferred - The quantity in Stock and Available columns is  reduced.
- Stock area to which  items are transferred - The quantity in Stock and Available columns is  increased.
- An entry is made  for serial numbers transferred in the Serial number history browser.



A company that transfers stock across locations can track  stock that is in transit through the stock transfer profile (Select **Options** > **New 
 Request** > **In New Window**  from the **Stock Transfer** profile).


The stock status changes during the three different stages  of stock transfer - Request, In-Transit and Completed.


**Stock Transfer - Request stage**


Stock that is in Request stage is specified in this profile.  The status of the Available stock during Request stage:

- Requesting location  - Total and Available Stock (No decrease)
- Origin Location  - Total and Available Stock (No increase)



**Stock Transfer - In-Transit stage**


Stock is temporarily transferred to the In-transit bin specified  in the flow control preferences during this stage. (**Locations**  profile > **Stock Transfer** >  **Inventory Adjustment** > **Stock Transfer Transit State** field).


The status of the Available quantity of stock during In-Transit  stage:

- **Origin 
 Location** - Available stock decreases by transferred quantity
- **Requesting 
 Location** - No increase due to transfer in Available stock



**Stock Transfer - Completed Stage**


Stock is again moved from the In-transit bin to the To Bin  of the Requesting Location during this stage. The status of the Available  stock during Completed stage:

- **Origin 
 Location** - Total and Available stock decreases by stock transferred  (Available Stock minus Stock Transferred)
- **Requesting 
 Location** - Total and Available stock  increases  by stock transferred (Available Stock plus Stock Transferred)



You can specify an In-transit bin for automatically transferring  stock In Transit from the Stock Transfer Transit State drop-down list  in **File** > **Setup**  > **Accounting** > **Location/Sub-Location**  profile > **Stock Transfer** >  **Inventory Adjustment** tab.


{:.see_also}
See also
: [Tracking  Stock-in-Transit]({{site.wm_baseurl}}/misc/tracking_stocks_in_transit.html)
: [Other  Flow Control]({{site.bp_chm}}/other-flow-control/the-other-flow-control-dialog-box/other_flow_control_general_tab_step_by_step.html)
