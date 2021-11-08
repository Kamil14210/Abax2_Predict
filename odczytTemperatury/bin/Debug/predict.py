import joblib
import numpy as np
from tensorflow.keras.models import load_model

scaler = joblib.load("./scaler.gz")
model = load_model("./lstm_model_30_5.h5")

temperature = []
with open("./input.txt") as f:
    content = f.readlines()
    for line in content:
        temperature.append(float(line.rstrip("\n")))

temperature = np.array(temperature)
temperature_scaled = scaler.transform(temperature.reshape(-1, 1))
temperature_scaled = np.reshape(temperature_scaled, (temperature_scaled.shape[1], temperature_scaled.shape[0], 1))

predicted_temperature_scaled = model.predict(temperature_scaled)
real_temperature = scaler.inverse_transform(predicted_temperature_scaled)

with open("./output.txt", "w") as f:
    for value in real_temperature[0]:
        f.write(str(value) + "\n")