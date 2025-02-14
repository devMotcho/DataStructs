input = "24:00:00"

min_to_sec = 60
hour_to_sec = 60 * 60

def convert_string_to_sec(i):
    hours = int(i.split(":")[0]) * hour_to_sec
    mins = int(i.split(":")[1]) * min_to_sec
    secs = int(i.split(":")[-1])


    return hours + mins + secs



print(convert_string_to_sec(input))