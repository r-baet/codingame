module OutputGenerator

let generate enemy1 dist1 enemy2 dist2 =
    if dist1 < dist2 then enemy1
    else enemy2
