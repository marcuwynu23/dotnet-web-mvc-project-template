1. **Tenants:**

   - tenant_id (Primary Key)
   - first_name
   - last_name
   - email
   - phone_number
   - emergency_contact_name
   - emergency_contact_number
   - lease_start_date
   - lease_end_date
   - rent_amount
   - security_deposit
   - payment_method
   - status (active/inactive)

2. **Rooms:**

   - room_id (Primary Key)
   - room_number
   - room_type
   - description
   - amenities
   - price
   - status (available/booked)

3. **Payments:**

   - payment_id (Primary Key)
   - tenant_id (Foreign Key referencing Tenants table)
   - amount
   - payment_date
   - payment_method
   - status (paid/unpaid)

4. **MaintenanceRequests:**

   - request_id (Primary Key)
   - tenant_id (Foreign Key referencing Tenants table)
   - room_id (Foreign Key referencing Rooms table)
   - request_date
   - description
   - status (pending/in progress/completed)

5. **Announcements:**

   - announcement_id (Primary Key)
   - title
   - content
   - date_created

6. **Messages:**

   - message_id (Primary Key)
   - sender_id (Foreign Key referencing Tenants or Landlord table)
   - recipient_id (Foreign Key referencing Tenants or Landlord table)
   - subject
   - content
   - date_sent
   - status (read/unread)

7. **RoomBookings:**

   - booking_id (Primary Key)
   - tenant_id (Foreign Key referencing Tenants table)
   - room_id (Foreign Key referencing Rooms table)
   - booking_date
   - check_in_date
   - check_out_date
   - status (confirmed/canceled)

8. **AccessLogs (Optional, for access control management):**

   - log_id (Primary Key)
   - tenant_id (Foreign Key referencing Tenants table)
   - room_id (Foreign Key referencing Rooms table)
   - access_date
   - access_time
   - access_type (entry/exit)

9. **LaundryBookings (Optional, for laundry management):**

   - booking_id (Primary Key)
   - tenant_id (Foreign Key referencing Tenants table)
   - date
   - time_slot
   - status (confirmed/canceled)

10. **Visitors (Optional, for visitor management):**

    - visitor_id (Primary Key)
    - tenant_id (Foreign Key referencing Tenants table)
    - visitor_name
    - visitor_contact
    - check_in_date
    - check_out_date

11. **Reviews (Optional, for tenant reviews):**
    - review_id (Primary Key)
    - tenant_id (Foreign Key referencing Tenants table)
    - rating
    - comment
    - date_posted
