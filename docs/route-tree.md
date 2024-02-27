### Landlord Perspective:

1. **Dashboard:**
    - `/dashboard`
2. **Tenant Management:**
    - `/tenants`
        - `/create`
        - `/view/<tenant_id>`
            - `/edit`
            - `/delete`
        - `/payments`
            - `/view/<payment_id>`
                - `/edit`
                - `/delete`
    - `/rent`
        - `/collect`
        - `/reminders`
    - `/reports`
        - `/tenant_activity`
        - `/rent_payments`
3. **Room Management:**
    - `/rooms`
        - `/available`
        - `/bookings`
            - `/calendar`
            - `/virtual_tours`
    - `/pricing`
        - `/seasonal`
        - `/room_types`
4. **Maintenance Management:**
    - `/maintenance`
        - `/submit`
        - `/status`
        - `/history`
5. **Communication:**
    - `/announcements`
        - `/send`
    - `/messages`
        - `/send/<tenant_id>`
        - `/inbox`
            - `/view/<message_id>`
                - `/reply`
    - `/complaints`
6. **Reports and Analytics:**
    - `/reports`
        - `/overview`
        - `/analytics`
    - `/integrations`
        - `/accounting`
        - `/utilities`
7. **Additional Features (Optional):**
    - `/access_control`
    - `/laundry_management`
    - `/inventory`
    - `/visitor_management`
    - `/marketing`
        - `/advertising`

### Tenant Perspective:

1. **Dashboard:**
    - `/dashboard`
2. **Payment Management:**
    - `/payments`
        - `/pay`
        - `/history`
        - `/auto_payment`
3. **Maintenance Requests:**
    - `/maintenance`
        - `/submit`
        - `/status`
            - `/view/<request_id>`
    - `/rules`
    - `/announcements`
4. **Communication:**
    - `/messages`
        - `/inbox`
            - `/view/<message_id>`
                - `/reply`
    - `/contact_landlord`
5. **Additional Features (Optional):**
    - `/laundry_booking`
    - `/visitor_info`
    - `/rate_review`
