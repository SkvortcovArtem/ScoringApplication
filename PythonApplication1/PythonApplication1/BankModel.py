import numpy as np
import pandas as pd 
import os
from sklearn.model_selection import train_test_split
from sklearn.ensemble import AdaBoostClassifier
from sklearn.preprocessing import StandardScaler
from sklearn import svm, datasets
from sklearn.model_selection import GridSearchCV
import joblib

print(os.path.abspath(__file__))
print(os.path.dirname(os.path.abspath(__file__)))
os.chdir(os.path.dirname(os.path.abspath(__file__)))
df_d = pd.read_csv("bankdata.csv", sep=';')
df_d.shape
df_d.dtypes
df_d['EXT_SOURCE_3'] = df_d['EXT_SOURCE_3'].str.replace(',', '.').astype('float64')
df_d['EXT_SOURCE_2'] = df_d['EXT_SOURCE_2'].str.replace(',', '.').astype('float64')
df_d['DAYS_LAST_PHONE_CHANGE'] = df_d['DAYS_LAST_PHONE_CHANGE'].astype('float64')
df_d.dtypes
df_d = pd.get_dummies(df_d)
x=df_d.drop('TARGET', axis = 1)
y=df_d['TARGET']
X_train, X_test, y_train, y_test = train_test_split(x, y, test_size=0.25)

scaler = StandardScaler()
scaler.fit(x)
X_train_norm = scaler.transform(X_train)
X_test_norm = scaler.transform(X_test)

ada = AdaBoostClassifier()
ada.fit(X_train_norm, y_train)

y_predict_train_ada = ada.predict(X_train_norm)
y_predict_test_ada = ada.predict(X_test_norm)

y_train_prediction_proba_ada = ada.predict_proba(X_train_norm)[:, 1]
y_test_prediction_proba_ada = ada.predict_proba(X_test_norm)[:, 1]

AdaBoostClassifier().get_params().keys()
param_grid_ada = {'learning_rate':[1,2,3],'algorithm':['SAMME', 'SAMME.R']}
grid_ada=GridSearchCV(AdaBoostClassifier(),param_grid_ada,verbose = 3)
grid_ada.fit(X_train_norm,y_train)

print(grid_ada.best_params_) 
grid_predictions_ada = grid_ada.predict(X_test_norm)
joblib.dump(grid_ada, 'model_file_ada.pkl')