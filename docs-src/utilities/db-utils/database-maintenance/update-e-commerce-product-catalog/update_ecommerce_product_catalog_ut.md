---
title: Update E-Commerce Product Catalog
---

# Update E-Commerce Product Catalog


For **Everest eStorefront 
 Standard** and **Everest eStorefront 
 Professional**, the E-Commerce Product Catalog must be updated before  web shoppers browse the shop for the first time. After that, it must be  updated whenever a user changes the price of an item or creates an item  on the desktop to update the online .Net web shop. You can schedule this  update to occur automatically. Even when the E-Commerce Product Catalog  updates are scheduled, you have the option to update the E-Commerce Product  Catalog immediately at any time.


{:.steps}
To schedule the E-Commerce Product Catalog  updates, do the following:

- On the **Everest**  desktop, select **Utility** > **Database Maintenance** > **Update 
 E-Commerce** **Product Catalog**.  You will see the **E-Commerce Product Catalog 
 Update Schedule**.
- Schedule your updates  based upon how frequently prices are changed and items are added in **Everest**. Prices will not update and  new items will not be added until the scheduled time.
- Click the **Save Schedule** button.



{:.note}
To update the E-Commerce Product Catalog immediately,  click the **Execute Now** button.


After running the product catalog update, prices are immediately  updated on item detail and listing pages.  Product  prices for items already in a logged in shopper's cart will not be updated.  These prices will expire when the shopper's session expires (as defined  in the E-Commerce Preferences) or when the shopper takes one of the following  actions:


1. Clicks the "Update cart" button


2. Retrieves a "saved cart" that does not  use current prices


3. Applies a "promotion code" to the cart


Guest shoppers (not logged in) with items in their cart will  have prices updated on the above actions and when they click "Proceed  to Checkout" and are forced to login.


Before the site updates the prices in the cart, a message  is displayed to the shopper.


This design serves two objectives:

- Honors the price  of items added to the cart for a logged in shopper, while still protecting  the merchant with session expiration and the fact that shoppers are automatically  logged out when they close the browser (only cart contents are kept)
- Allows site to be  modified to use custom pricing for logged in shoppers



{:.see_also}
See also
: [Database  Maintenance]({{site.utl_baseurl}}/db-utils/database-maintenance/database_maintenance_utility_content.html)
