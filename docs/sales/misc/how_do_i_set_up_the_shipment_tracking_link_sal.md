---
title: How Do I Set up the Shipment Tracking Link?
---

# How Do I Set up the Shipment Tracking Link?


If the **Shipment Tracking** field  in your **Shipment Tracking Information**  browser (path: From the **Sales Orders**  browser or the **Sales Invoices**  browser, select **Options** > **Shipment Tracking** **Information**  or press **Ctrl + F11**), does not  have a URL link, it will need to be configured.


{:.steps}
To configure the Shipment Tracking field  link in the Shipment Tracking Information browser, do the following:

- From the main menu  bar, select **File** > **Setup**  > **Freight** > **Delivery 
 Methods**. You will see the **Delivery 
 Methods** browser. Open the **Delivery 
 Method** profile for your carrier.



![]({{site.sp_baseurl}}/img/delivery_methods_shipment_tracking_url_sal.gif)


**Figure: Delivery Method Profile with Shipment  Tracking URL**

- In the **Shipment 
 Tracking URL** field, enter the URL of the shipment tracking page  of your carrier. To find the correct link for your carrier, go to your  carrier's website and locate the page for entering web tracking information.  Copy the link from the address bar to the Shipment Tracking URL field  of your **Delivery Method** profile.  UPS and FedEx URL links are shown below and are **subject 
 to change**.
- Add the following  **UPS** link to the **Shipment 
 Tracking URL** field in your UPS Delivery Methods in **Everest**:[
http://wwwapps.ups.com/WebTracking/processInputRequest?TypeOfInquiryNumber=T&InquiryNumber1=](http://wwwapps.ups.com/WebTracking/processInputRequest?TypeOfInquiryNumber=T&amp;InquiryNumber1=)
- Add the following  **FedEx** link to the **Shipment 
 Tracking URL** field in your FedEx Delivery Methods in **Everest**:  [
http://fedex.com/Tracking?action=track&tracknumber\_list=](http://fedex.com/Tracking?action=track&amp;tracknumber_list=)
- Save your changes.  Users can now press **Ctrl + Click**  the link on the **Shipment Tracking****Information** browser (or the link  on the **Shipment Tracking** tab in  a sales document) to get the delivery status from the carrier's website.  See the example in the following figures.



**![]({{site.sp_baseurl}}/img/sales_invoice_sal.jpg)**


**Figure: Shipment Tracking Link in a Sales Document**


**![]({{site.sp_baseurl}}/img/shipment_tracking_information_dialog_sal.jpg)**


**Figure: Shipment Tracking Information Browser**


**![]({{site.sp_baseurl}}/img/shipment_tracking_information_sal.jpg)**


**Figure: Delivery Status on Carrier Website**


{:.see_also}
See also
: [How  do I Get the Delivery Status from within Everest?]({{site.sp_baseurl}}/misc/how_do_i_get_the_delivery_status_from_within_everest_sal.html)
: [Shipping  Software Integration]({{site.sp_baseurl}}/sales-docs/docs-profile/contents/tab-details/ship-trk/shipping_software_integration_sal.html)
