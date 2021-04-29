import geocoder


g = geocoder.komoot("Phoenix, AZ")
print(g.latlng)
print(g.country)
print("\n")


g = geocoder.arcgis([51.5074,0.1278], method='reverse')
print(g.city)
print(g.state)
print(g.country)
print("\n")


g = geocoder.ip('8.8.8.8')
print(g.ip)
print(g.postal)
print(g.latlng)
print(g.city + " " + g.state)
print("\n")


g = geocoder.ip('me')
print(g.ip)
print(g.postal)
print(g.latlng)
print(g.city + " " + g.state)
print("\n")

print("House Address")
g = geocoder.komoot("1600 Pennsylvania Avenue NW, Washington D.C.")
print(g.housenumber)
print(g.postal)
print(g.street)
print(g.city)
print(g.state)
print(g.country)