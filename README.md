# Pico y Placa predictor

## "We’d like you to write a "Pico y Placa" predictor."

### Inputs
- License plate number. (the full number ie: AAA-0001)
- Date. (as a String)
- A time.

### Rules
- Vehicles with license plates ending in 1 and 2 do not circulate on Monday.
- Vehicles with license plates ending in 3 and 4 do not circulate on Tuesday.
- Vehicles with license plates ending in 5 and 6 do not circulate on Wednesday.
- Vehicles with license plates ending in 7 and 8 do not circulate on Thursday.
- Vehicles with license plates ending in 9 and 0 do not circulate on Friday.
- Saturdays and Sundays there is no restriction.
- The time restriction is from 07:00 to 09:30 and from 16:00 to 19:30.

### User Interface
- A textbox to write the license plate
- A dropdown with the days of the week
- A datepicker with the time in hours

### Output
- A message indicating if it applies the restriction or not
