import numpy as np
import pandas as pd 
import os
from sklearn.model_selection import train_test_split
from sklearn.ensemble import AdaBoostClassifier
from sklearn.preprocessing import StandardScaler
from sklearn import svm, datasets
from sklearn.model_selection import GridSearchCV
import joblib

grid_ada_lib = joblib.load(os.path.dirname(os.path.abspath(__file__)) + '\model_file_ada.pkl')

print(os.path.abspath(__file__))
print(os.path.dirname(os.path.abspath(__file__)))
os.chdir(os.path.dirname(os.path.abspath(__file__)))
df_d = pd.read_csv("bankdata.csv", sep=';')

df_new = pd.read_csv("newclients.csv", sep=';')
df_old = pd.read_csv("bankdata.csv", sep=';')

df_new.dtypes
df_new.columns = ['Id_Client', 'TARGET', 'DAYS_BIRTH', 'EXT_SOURCE_3', 'EXT_SOURCE_2', 'NAME_EDUCATION_TYPE', 'REGION_RATING_CLIENT' , 'NAME_INCOME_TYPE', 'CODE_GENDER' , 'DAYS_LAST_PHONE_CHANGE', 'DAYS_ID_PUBLISH', 'REG_CITY_NOT_WORK_CITY']
df_old.dtypes

df_new['EXT_SOURCE_3'] = df_new['EXT_SOURCE_3'].str.replace(',', '.').astype('float64')
df_new['EXT_SOURCE_2'] = df_new['EXT_SOURCE_2'].str.replace(',', '.').astype('float64')
df_new['DAYS_LAST_PHONE_CHANGE'] = df_new['DAYS_LAST_PHONE_CHANGE'].astype('float64')

df_old['EXT_SOURCE_3'] = df_old['EXT_SOURCE_3'].str.replace(',', '.').astype('float64')
df_old['EXT_SOURCE_2'] = df_old['EXT_SOURCE_2'].str.replace(',', '.').astype('float64')
df_old['DAYS_LAST_PHONE_CHANGE'] = df_old['DAYS_LAST_PHONE_CHANGE'].astype('float64')

unite = [df_old, df_new]
df_result = pd.concat(unite, ignore_index = True)

new_len = len(df_new.index)

df_result = pd.get_dummies(df_result)
X_result=df_result.drop('TARGET', axis = 1)
Y_result=df_result['TARGET']
scaler = StandardScaler()
scaler.fit(X_result)

X_new_norm = scaler.transform(X_result)

score = grid_ada_lib.score(X_result.head(len(X_result.index) - new_len), Y_result.head(len(Y_result.index) - new_len))

res = X_new_norm[-new_len:]
pred = grid_ada_lib.predict(res)
df_descision = pd.DataFrame(pred)
df_descision.to_csv('descision.csv', sep=';', header=False, index=False)
print(score)
print(os.getcwd())