'''

TODO: Muthu

1. You need to set up a basic binary ML classifier here. 
2. Use a simple dataset on kaggle

'''
from tensorflow import keras

model = keras.models.load_model('server/Dog-V-Cat')
#print(model.summary())

from tensorflow.keras.preprocessing import image
import numpy as np

# Load the image
img_path = '/home/qualitas/Downloads/images.jpeg' 
img = image.load_img(img_path, target_size=(150, 150))  
img_array = image.img_to_array(img) 
img_array = np.expand_dims(img_array, axis=0)  


img_array = img_array / 255.0  

# Make predictions
predictions = model.predict(img_array)

# Interpret the predictions
if predictions[0][0] > predictions[0][1]:
    print("It's a Cat!")
else:
    print("It's a Dog!")

