# ๊ฐ๋ฐ ์ผ์ง ๐ฑโ๐

> ์ฒญํ ๊ฐ๋ฐ ์ผ์ง 

<br>

### 2021-03-10

- ์๊น๋ณ ๋งต ์ปจ์ ์ ํ๊ธฐ

  | ์๊น        | ์๋ฏธ                                                         |
  | ----------- | ------------------------------------------------------------ |
  | ๋นจ๊ฐ        | ๋ธ์ ์ง๋ ์ปจ์ (์ผ์ ๋ง์น๊ณ  ์ง์ ๋์์ค๋ ๊ธธ ๋ธ์์ด ์ง๊ณ  ์๋ ๋๋) |
  | ์ฃผํฉ        | ๋จํ์ผ๋ก ๋ฌผ๋ค์ด ์๋ ๊ธธ์ ๊ฑท๋ (๊ฐ์์ ๋ง์ ํ๋์ ๋ณด์ฌ์ฃผ๊ธฐ โ ๊ฒฝ์พ ๋์ฒ) |
  | ๋ธ๋        | ํฉ๊ธ๋น ๊ฑด๋ฌผ์ด๋ ์ฌ๋ง (์ฌ๋ง์ ์ฝ๊ฐ ํฉํํ ๋๋์ด ์์ ์๋ ์์ผ๋๊น ํฉ๊ธ๋น ๊ฑด๋ฌผ ์์ ํํํ๋ ๋๋...) |
  | ์ด๋ก        | ์ค์๊ธธ ๊ฑธ์ผ๋ฉด์ ์๋ฌผ๋ค๊ณผ ์ํตํ๋ ๋๋ (ํผํค์น๋~)           |
  | ํ๋        | ๋ฐ๋ค, ์ฌ์์ ๊ธธ ๋ฐ๋ผ๊ฐ๋ฉด์ ~~ (์กฐ์ฝ๋, ๋ถ๊ฐ์ฌ๋ฆฌ ๊ฐ์ ๊ฑฐ๋ ์ํธ์์ฉ) ์๋๋ฉด ๋ฐฐ ํ๊ณ  ๋ค๋๋ฉด์ |
  | ์ง์ฒญ        | ๋ณด๋ฆ๋ฌ ๋ฌ ๋ฐค, ํํ๋ก์ด ๋๋                                  |
  | ๋ณด๋ผ        | ๋ณด๋๋น ์ฒ ์ ํํ  (๋ชฝํ์ ์ธ ๋๋)                           |
  | ์์ฃผ (ํํฌ) |                                                              |

  

- ํ์์ค

๋นจ๊ฐ - ํฌ๋ฆฌ์ค๋ง์ค ๋ฐฉ, ๋๋ก 

๋ธ๋ - ํฉ๊ธ๋น ๊ฑด๋ฌผ

ํ๋ - ๋ํ์  ๋ณด๋ฌผ์์, ์ด์  

์ง์ฒญ - ๋ฐฐํ๊ณ  ๋ฐ๋ง๋ถ์ด



### 2021-03-11

SubPJT1 ํ๋ฉด์ ์๊ธด ์๋ฌ

1.  raise RuntimeError(message)

ํด๊ฒฐ ๋ฐฉ๋ฒ:

```
File "/home/gerald/miniconda3/envs/maskrcnn_benchmark/lib/python3.8/site-packages/torch/utils/cpp_extension.py", line 1413, in _run_ninja_build
raise RuntimeError(message)
RuntimeError: Error compiling objects for extension

์ด ์๋ฌ๊ฐ ๋ด์ ๋: ํ์ฌ ์ค์น๋์ด์๋ CUDA์ ๋ง์ง์์ pytorch ํจํค์ง๊ฐ ์ค์น๋์ด ์์ด์ ์๊ธด ๋ฌธ์ 

1) ํ์ฌ ์ค์น๋์ด์๋ cuda ๋ฒ์ ๊ณผ ๋ง๋ pytorch ํจํค์ง๋ฅผ ์ค์น
conda install pytorch torchvision cudatoolkit=11.2 -c pytorch

conda install pytorch torchvision cudatoolkit=10.0 -c pytorch

2) ๋ง์ฝ image_captioning.py๋ฅผ ์คํํ  ๋ DLL load failed๊ฐ ๋ฌ๋ค๋ฉด
ํ๊ฒฝ ๋ณ์์ 'C:\ProgramData\Anaconda3\Library\bin' ๋ฅผ ์ถ๊ฐํด์ค๋ค

๋ง์ฝ ๊ทธ๋๋ ์ ๋๋ฉด Intel-openmp์ ์ค์นํด๋ณธ๋ค.. ์ฐธ๊ณ : https://mclearninglab.tistory.com/30
```

2. DLL load failed : ์ง์ ๋ ๋ชจ๋์ด ~ 

ํด๊ฒฐ๋ฐฉ๋ฒ:

```
CuDNN ๋ฒ์ , pytorch ๋ฒ์ , cuda ๋ฒ์ ์ ๋ง์ถฐ์ผ ํจ
```



### 2021-03-12

```
logging ์ฌ์ฉํ๊ธฐ

์ฌ์ฉํ๋ ์ด์ : 
	- ํ์ด์ฌ ํ๋ก๊ทธ๋จ์์ ๋ฐ์ํ ๋ก๊ทธ๋ฅผ ํ์ผ๋ก ๊ธฐ๋กํ๋ค.
	- ๋งค์ผ ์๋ก์ด ํ์ผ์ด ์์ฑ๋๋ฉฐ, ์์ฑ๋ ์ง๋ฅผ ํ์ผ๋ช์ ๋ฃ๊ณ  ์ถ๋ค.

์ฌ์ฉ ๋ฐฉ๋ฒ: 
	1) logging ๊ณผ logging์ handler๋ฅผ import
	
	- __init__.py ๋ฅผ ์ฐ์ง์์ผ๋ฉด ์ด๋ ๊ฒ ํ์ ๋ชจ๋ (= logging.handler) ๋ฅผ ๋ณ๋๋ก ๊ฐ์ ธ์์ผ ํ๋ ๊ฒฝ์ฐ๋ ์๋ค.
	
	 
	
	2) logging.Formatter
	
	- ์ด๋ค ํ์์ผ๋ก ๋ก๊ทธ๊ฐ ์์ฑ๋ ์ง๋ฅผ ์ ํ๋ค
	
	โ ์ฌ๊ธฐ์๋ ๋ก๊ทธ ์์ฑ์๊ฐ(ms ๋จ์๊น์ง) + "," + ๋ฉ์์ง๋ก carLogFormatter ์ค์ 
	
	- %(asctimes)s ๋ ๋ก๊ทธ๊ฐ ๊ธฐ๋ก๋๋ ์๊ฐ
	
	- %(message)s ๋ ์๋ ฅํ ๋ก๊ทธ๊ฐ ๋๋ค.
	
	 
	
	3) handler.TimedRotatingFileHandler
	
	- ๋งํฌ ์ฐธ์กฐ: https://docs.python.org/3/library/logging.handlers.html#timedrotatingfilehandler
	
	- ์๋ก์ด ํ์ผ์ ๋ง๋๋ ๊ธฐ์ค
	
	- ์ ์ฅํ  ํ์ผ๋ช์ car.log
	
	- when='midnight'์ ๊ฒฝ์ฐ ๋งค์ผ๋ฐค ์์ ์ ์๋ก์ด ํ์ผ์ด ๋ง๋ค์ด์ง๋ค.
	
	- ์ด๋ ๋ง๋ค์ด์ง๋ ํ์์ suffix์ ๋ฐ๋ผ ์ค์ ๋๋ค.
	
	โ ์๋ฅผ ๋ค๋ฉด ์ฌ๊ธฐ์๋ carLogHandler.suffix = "%Y%m%d" ์ด๋ฏ๋ก car.log.20180504
	
	-
	
	4) ์ค์  ์ฌ์ฉํ  logger๋ฅผ ์์ฑํ๊ณ  ์ค์ 
	
	- carLogger ๋ฅผ ๋ง๋ค๊ณ 
	
	- ์ถ๋ ฅ๋ ๋ฒจ์ INFO ์ด์์ผ๋ก ์ค์ ํ๊ณ 
	
	- handler๋ฅผ ์ถ๊ฐ
	
	 
	
	5) ์ค์  ์ฌ์ฉ
	
	- carLogger.info("car is coming") ๋ผ๊ณ  ์ฌ์ฉํ๋ฉด
	
	- 2018-05-04 08:52:11, 599,car is coming ์ด๋ผ๊ณ  car.log ๋ผ๋ ํ์ผ์ ์ ์ฅ์ด ๋๋ค.
	
	โ ๋ฐค 12์๊ฐ ์ง๋๋ฉด car.log.20180504 ์ ๊ฐ์ ์ด๋ฆ์ผ๋ก ๋ค๋ฅธ ํ์ผ์ด ์์ฑ๋จ
```

```
ํ์ด์ฌ self ์ดํดํ๊ธฐ

self๋ ๊ฐ์ฒด์ ์ธ์คํด์ค ๊ทธ ์์ฒด๋ฅผ ๋งํ๋ค. 
์ฆ, ๊ฐ์ฒด ์๊ธฐ ์์ ์ ์ฐธ์กฐํ๋ ๋งค๊ฐ๋ณ์
๊ฐ์ฒด์งํฅ ์ธ์ด๋ ๋ชจ๋ ์ด๊ฑธ ๋ฉ์๋์ ์๋ณด์ด๊ฒ ์ ๋ฌํ์ง๋ง, ํ์ด์ฌ์ ํด๋์ค์ ๋ฉ์๋๋ฅผ ์ ์ํ  ๋ self๋ฅผ ๋ช์ํ๋ค.
๋ฉ์๋๋ฅผ ๋ถ๋ฌ์ฌ ๋ self๋ ์๋์ผ๋ก ์ ๋ฌ๋๋ค. self๋ฅผ ์ฌ์ฉํจ์ผ๋ก ํด๋์ค๋ด์ ์ ์ํ ๋ฉค๋ฒ์ ์ ๊ทผํ  ์ ์๊ฒ๋๋ค.

๊ทผ๋ฐ ๊ทธ๋์ tacotron.py ์์ ์ self๋ฅผ ์ฐ๋์ง ์ดํด๊ฐ ์ ๋จ..
```



### 2021-03-15

```
STT, TTS๋ ์๋๋ก์ด๋์์ ๋ฐ๋ก ๊ตฌํํ๊ธฐ
```



### 2021-03-16

```
1. VR์์ ๋ฉํฐ๋ฒ์ค ๊ตฌํํ๊ธฐ

PUN(Photon Unity Networking) : ๋ฉํฐํ๋ ์ด์ด ๊ฒ์์ฉ ์ ๋ํฐ ํจํค์ง ์ฌ์ฉ
```

```
2. ๋ชจ์ ์ธ์

tensorflow.js / https://github.com/iconms12/Image_Captioning (pythorch ์ด๋ฏธ์ง ์บก์๋)
YOLO / ๋ชจ์ ์ธ์ API ๋ฑ ์๋ฃ ์กฐ์ฌ ํ์
```



### 2021-03-17

ec2์ nginx ์ค์นํ๊ณ  html ๋ฐฐํฌํ๊ธฐ

```
$ sudo apt-get update
$ sudo apt-get install nginx
```

sites-available๋ก ๊ฐ์ default ํ์ผ์ ์์ ํ๋ค.

```
$ cd /etc/nginx/sites-available
```

default

root /home/ubuntu/s04p22a401/Web/eriene; (index.html ์ด ์๋ ์์น) ๋ก ์์  ํ nginx ์์

```
$ systemctl start nginx
```

์ฃผ์๋ก ๋ค์ด๊ฐ์ ์ ๋์ค๋์ง ํ์ธ

```
http://j4a401.p.ssafy.io/
```



### 2021-03-18

```
photon unity network ์ฌ์ฉ์ค๋น

- ์ ๋ํฐ 2019.04 (LTS ๋ฒ์  ๋ค์ด) -> Unity Hub: ์ ๋ํฐ ๋ฒ์  ๊ด๋ฆฌ๋ฅผ ์ฝ๊ฒ ํด์ฃผ๋ ํด
  (๋ชจ๋ ์ถ๊ฐ Android Build Support, iOS Build Support, WebGL Build Support, 		Windows Build Support, ํ๊ตญ์ด)
- unity asset store์์ photon ์ถ๊ฐ
```



### 2021-03-19

```
unity์ photon importํ๊ธฐ

- Unity asset store์์ PUN ๋ค์ดํ ๋ค appId ๋ฐ๊ธ๋ฐ๊ธฐ
- Unity ์คํ -> Window -> asset store -> PUN import -> appId ๋ถ์ฌ๋ฃ๊ธฐ
```

```
unity VScode์์ ์์ํ๊ธฐ (VS๋ง๊ณ )
์ ๋ํฐ ์ฐ๋์ ํ์ํ ์์กด ๋ผ์ด๋ธ๋ฌ๋ฆฌ ์ค์น
- ๊น: https://git-scm.com
- ๋ท๋ท ์ฝ์ด: https://microsoft.com/net/core
- ๋ชจ๋ธ: http://www.mono-project.com/download/
```



![keystore ์์ฑ](C:\Users\multicampus\AppData\Roaming\Typora\typora-user-images\image-20210319142628495.png)



### 2021-03-22

```
Unity-Firebase ์ฐ๋

firebase์์ ํ๋ก์ ํธ(Unity, Android) google-services.json์ ๋ฐ๊ธ๋ฐ์ ๋ค 
Unity ํ๋ก์ ํธ -> asset ํด๋ ๋ด์ ๊ฐ๋ค ๋๊ธฐ

Streaming assets/firebase-services-desktop.json์ด ์์ฑ๋๋ฉด ์ธ์ ์๋ฃ
!! ํ์ง๋ง unable to load google-services-desktop.json ๋ฑ ํ๋ฒ ๊ฐ ๋ก๋ ์ ๋๋ ๋ฌธ์ ๊ฐ ๋ฐ์ํ์ ๋
```

```
* unable to load google-services-desktop.json ํด๊ฒฐํ๊ธฐ

1. ํ์ฌ ํด๊ฒฐ๋ฐฉ๋ฒ์ ์์ด unity 2019.3.15f๋ฒ์ ์ผ๋ก ๋ค์ด๊ทธ๋ ์ด๋ ํ์๋ค....?!
	-> ์ฐ๋ฆฌ๋ 2019.4์ธ๋ฐ,,,, ใ ์ผ๋จ ํ๋ฆฐ๋,,
	
2. google-services.json ํ์ผ ๋๋ฌธ์ด์๋๋ฐ, ํ์ผ ์์น๋ฅผ StreamingAssets๋ก ์ฎ๊ฒจ์ฃผ๋ฉด ํด๊ฒฐ๋๋ค.
	-> ํด๊ฒฐ ์ ๋๋ค.^^
	
3. https://firebase.google.com/docs/unity/setup?hl=ko ์ญ์ ๊ณต์๋ฌธ์ ์ฐธ์กฐํ๊ธฐ ใ..
    .NET 4.x๋ฅผ ์ฌ์ฉํ๋ ๊ฒฝ์ฐ ๋ค์๊ณผ ๊ฐ์ ๋ฐฉ๋ฒ์ผ๋ก ์ปดํ์ผ ์ค๋ฅ๋ฅผ ํด๊ฒฐํ์ธ์.

    ๋ชจ๋  ํ๋ซํผ์์ ๋ค์ DLL์ ์ญ์ ํ๊ฑฐ๋ ์ฌ์ฉ ์ค์งํฉ๋๋ค.
    Parse/Plugins/Unity.Compat.dll
    Parse/Plugins/Unity.Tasks.dll
    ๋ชจ๋  ํ๋ซํผ์์ ๋ค์ DLL์ ์ฌ์ฉ ์ค์ ํฉ๋๋ค.
    Parse/Plugins/dotNet45/Unity.Compat.dll
    Parse/Plugins/dotNet45/Unity.Tasks.dll
    
    ....
    
4. ๊ฒฝ๋ก์ ํ๊ธ์ ๋ค ์์ฐ --> ์ ๋ต...!! (๊ฒฝ๋ก์ ํ๊ธ์ ์ต๊ฐํจ ๋ฃ์ง ๋ง์...)
```



### 2021-03-23

```
Android-Unity ์ฐ๋์ํด Android Studio plugin ์์ ํ์ 

- ์ฐธ์กฐ
https://xinyustudio.wordpress.com/2015/12/31/step-by-step-guide-for-developing-android-plugin-for-unity3d-i/

```

ํ๋ก ํธ ๋ฐฐํฌํ๋ ๋ฐฉ๋ฒ ์ ๋ฆฌ

- EC2์ HTML ๋ฐฐํฌํ๊ธฐ
  https://www.notion.so/EC2-HTML-ee65722e4ed7484e88cc55b7cc6517f6

1. EC2 ์ ์(mobaXtreme ๊ฐ๋ฅ)

   ```
   $ ssh -i J4A401T.pem ubuntu@j4a401.p.ssafy.io
   ```

2. ec2์ nginx ์ค์นํ๊ณ  html ๋ฐฐํฌํ๊ธฐ

   ```
   $ sudo apt-get update
   $ sudo apt-get install nginx
   ```

3. git clone https://lab.ssafy.com/s04-ai-speech-sub3/s04p23a401.git ํ๊ณ  index.html ์์น ํ์ธ

4. sites-available๋ก ๊ฐ์ default ํ์ผ์ ์์ ํ๋ค.

   ![https://user-images.githubusercontent.com/43662673/112101474-0a849000-8bea-11eb-8e5c-dba07af2414b.png](https://user-images.githubusercontent.com/43662673/112101474-0a849000-8bea-11eb-8e5c-dba07af2414b.png)

   ```
   $ cd ~
   $ cd /etc/nginx/sites-available
   $ sudo vi default
   ```

   4 - 1. default ํ์ผ ์์ 

   ![https://user-images.githubusercontent.com/43662673/112101684-6b13cd00-8bea-11eb-8b13-b0c3ba33ad7a.png](https://user-images.githubusercontent.com/43662673/112101684-6b13cd00-8bea-11eb-8b13-b0c3ba33ad7a.png)

   root /home/ubuntu/s04p22a401/Web/eriene; (index.html ์ด ์๋ ์์น) ๋ก ์์  ํ nginx ์์

   ```
   $ systemctl start nginx
   ```

5. ์ฃผ์๋ก ๋ค์ด๊ฐ์ ์ ๋์ค๋์ง ํ์ธ

   ```
   <http://j4a401.p.ssafy.io/>
   ```



- EC2์ HTML ์๋ฐ์ดํธํ๊ธฐ

  https://www.notion.so/EC2-HTML-b8e0513e699c402d96a0c3c99023d8c6

  1. EC2 ์ ์(mobaXtreme ๊ฐ๋ฅ)

     ```
     $ ssh -i J4A401T.pem ubuntu@j4a401.p.ssafy.io
     ```

  2. git directory๋ก ์ด๋

  ![https://user-images.githubusercontent.com/43662673/112101929-d3fb4500-8bea-11eb-8c21-eac62ae23c7e.png](https://user-images.githubusercontent.com/43662673/112101929-d3fb4500-8bea-11eb-8c21-eac62ae23c7e.png)

  ```
  $ cd s04p23a401
  $ git pull
  $ sudo service nginx restart
  ```

  3. ์ฃผ์๋ก ๋ค์ด๊ฐ์ ์ ๋์ค๋์ง ํ์ธ

  ```
  http://j4a401.p.ssafy.io/
  ```


    ์ฌ๋ฌ ์๋ฌ๋ค

    ```
    Could not open lock file /var/lib/apt/lists/lock - open (13: Permission denied)
    
    1. sudo su, su ๋ก ๊ด๋ฆฌ์ ๊ณ์ ์ผ๋ก ๋์ด๊ฐ๋ค
    2. $ rm /var/lib/apt/lists/lock
    3. $ rm /var/cached/apt/archives/lock
    
    ๊ทธ ๋ค์ $ apt-get upgrade -y ํ๋ฉด apt-get์ด ์๋ฌ ์์ด ์ ๋๋ ๊ฒ์ ๋ณผ ์ ์๋ค.
    ```
    
    2. E: The repository 'http://ppa.launchpad.net/certbot/certbot/ubuntu focal Release' does not have a Release file. ์๋ฌ
    
    ![image-20210323195500613](C:\Users\0901B\AppData\Roaming\Typora\typora-user-images\image-20210323195500613.png)
    
    ```
    sudo apt-add-repository -r ppa:certbot/certbot
    ```
    
    After that, the following commands do not generate any errors:
    
    ```
    sudo apt update
    sudo apt-get update
    ```


ubuntu์ ๊ธฐ๋ณธ์ผ๋ก yum์ด ์ค์น๋์ด ์๋ ๊ฒ ๊ฐ์ผ๋ ์ ๋ฒ ํ์ ๋ ๊ทธ๋ ๊ณ  ์ด๋ฒ ์ฐ๋ฆฌ ์๋ฒ์์๋ yum์ด ์๋ค..

![image](https://user-images.githubusercontent.com/43662673/112128641-f781b800-8c09-11eb-9f78-6644c3f5ea3e.png)



๊ทธ๋์  yum๋ถํฐ ์ค์นํ์

1. apt-get install yum
   ![image](https://user-images.githubusercontent.com/43662673/112129906-38c69780-8c0b-11eb-9dfb-283011d116fe.png)

   ์ ์ ํด๋ดค๋ค.. ์ญ์ ์ ๋๋ค.

2. yum-3.4.3.tar.gz ์ง์  ๋ค์ด๋ฐ๊ธฐ

   2 - 1. wget์ ์ด์ฉํ์ฌ ๋ค์ด๋ก๋ ํ๋ค.

   ![image](https://user-images.githubusercontent.com/43662673/112133768-5eee3680-8c0f-11eb-99ef-e9e1ce41ac2b.png)

   ```
   $ wget http://yum.baseurl.org/download/3.4/yum-3.4.3.tar.gz
   ```

   2 - 2. ํ์ฅ์๊ฐ tar.gz์ด๋ฏ๋ก tar์ ์ด์ฉํ์ฌ ์์ถ์ ํด์ ํ๋ค

   ```
   $ tar -xvzf yum-3.4.3-tar.gz
   ```

   2 - 3. ์์ถ์ ํด์ ํ๋ฉด ํด๋๊ฐ ์์ฑ๋๋ฏ๋ก, ํด๋น ํด๋๋ก ์ด๋

   ```
   $ cd yum-3.4.3
   ```

   -> ๋ณดํต์ ์ฌ๊ธฐ์ ./configure์ ๊ฐ์ make install์ ํ๋ผ๊ณ  ํด์ ๋งํ๋ค

   ์ผ๋จ ์ด ์ํ์์๋ ์ธ์์ ๋ชปํ๋ ๊ฑด ๋ง์ฐฌ๊ฐ์ง..

   ![image](https://user-images.githubusercontent.com/43662673/112131641-1afa3200-8c0d-11eb-980d-e663b48d9a0f.png)

   3 - 1. yum-3.4.3 ํด๋์ ์๋ yummain์ ์คํํ๋ค

   ```
   $ run ./yummain.py
   ```

   ![image](https://user-images.githubusercontent.com/43662673/112135205-e25c5780-8c10-11eb-8009-5bc47090f73e.png)

   ์ ๋๋ค...?



3. ์ด์ ๋ถํฐ๋ sudo apt install yum์ด ๊ฐ๋ฅํ๊ฒ ํ๊ธฐ

   ![image](https://user-images.githubusercontent.com/43662673/112136254-0d937680-8c12-11eb-938b-5e826b0518b6.png)

   ubuntu version ํ์ธ

   ```
   $ lsb_release -a
   ```

   ![image](https://user-images.githubusercontent.com/43662673/112136610-872b6480-8c12-11eb-9e34-bd6874919ecb.png)

   

4. ๋ฏธ๋ฌ์ฌ์ดํธ ๊ฑด๋๋ฆฌ๊ธฐ!

   

   1) ์ผ๋จ yum-3.4.3 ํด๋๋ก ์ด๋ -> etc/yum.repos.d 

   ![image](https://user-images.githubusercontent.com/43662673/112136841-dffafd00-8c12-11eb-9af4-19a719fd8789.png)

   yum.repos.d ํ์ผ์ด ์์ -> yum.conf ํ์ผ ๊ฑด๋๋ ค๋ณด๊ธฐ

    ![image-20210323204603821](C:\Users\0901B\AppData\Roaming\Typora\typora-user-images\image-20210323204603821.png)


### 2021-03-24

1. ์์  ๋ฐฉ๋ฒ

   ```
   $ wget https://raw.githubusercontent.com/certbot/certbot/7f0fa18c570942238a7de73ed99945c3710408b4/letsencrypt-auto-source/letsencrypt-auto -O /opt/certbot-auto
   
   $ chmod 755 /opt/certbot-auto
   
   $ mv /opt/certbot-auto /๊ธฐ์กด์ค์น๊ฒฝ๋ก/certbot-auto
   ```

2. certbot ํํ์ด์ง ๊ฐ์ ํ๋ผ๋ ๋๋ก ํ๊ธฐ

   ์ฐ๋ฆฌ ์๋ฒ๋ ubuntu 20.04๋๊น 

   ![image](https://user-images.githubusercontent.com/43662673/112248319-124f3d80-8c99-11eb-9226-5a855c359aeb.png)

   ์์ ๊ฐ์ด ๋ค์ด๊ฐ์ ํ๋ผ๋ ๋๋ก ๋ฐ๋ผํ๋ค.

   ```
   $ sudo snap install core; sudo snap refresh core
   $ sudo snap install --classic certbot
   $ sudo ln -s /snap/bin/certbot /usr/bin/certbot
   $ sudo certbot --nginx
   ```

   

![image](https://user-images.githubusercontent.com/43662673/112247741-2e9eaa80-8c98-11eb-9105-563d0357961a.png)



```
# openssl pkcs12 -export -in fullchain.pem -inkey privkey.pem -out keystore.p12 -name airpageserver -CAfile chain.pem -caname root
```

![image](https://user-images.githubusercontent.com/43662673/112248011-93f29b80-8c98-11eb-9577-e12008deb9fc.png)

๋น๋ฐ๋ฒํธ๋ ๊ท์ฐฎ์ผ๋ ๊ทธ๋ฅ root๋ก ใใ

์ด์จ๋  ์์ ๋ช๋ น์ด๋ฅผ ์น๊ณ  ๋๋ฉด keystore.p12๊ฐ ์์ฑ๋๋ค.

![image](https://user-images.githubusercontent.com/43662673/112248118-c0a6b300-8c98-11eb-884b-a3bc1da1202c.png)

mvํ๋ผ๊ณ  ํ์ง๋ง ๋ฌด์์ฐ๋๊น cp๋ก home ๋๋ ํ ๋ฆฌ๋ก ์ด๋

![image](https://user-images.githubusercontent.com/43662673/112248175-df0cae80-8c98-11eb-946a-6b5bd0533088.png)


### 2021-03-25

๋จผ์  ์  ํจ์ค๋ ์น์๋ฒ์ด๊ธฐ ๋๋ฌธ์ ํ์ฌ Ubuntu์์ ์ฌ์ฉํ๋ ํฌํธ๋ฅผ ํ์ธํ๋ค.

ํฌํธํ์ธ ์ํด nmap์ ์ค์นํ๋ค.

```
$ sudo apt-get install nmap
$ nmap localhost
```

![image](https://user-images.githubusercontent.com/43662673/112255119-f5b90280-8ca4-11eb-9b67-915ad8294efc.png)

8080ํฌํธ๋ฅผ ์ฌ์ฉํ๊ณ  ์์ง ์์ง๋ง,, ํน์ ๋ชจ๋ฅด๋๊น 7070 ํฌํธ๋ฅผ ์ฌ์ฉํ๊ธฐ๋ก ํ๋ค.

๊ทธ๋ฆฌ๊ณ  Jenkins๋ java๊ฐ ํ์ํ๊ธฐ ๋๋ฌธ์ java๊ฐ ์ค์น๋์ด ์๋์ง ๋ฒ์ ์ ํ์ธํ๋ค.

![image](https://user-images.githubusercontent.com/43662673/112255210-1f722980-8ca5-11eb-99b6-9c08da356878.png)



Jenkins ์ค์น๋ฅผ ์ํ repository key๋ฅผ ์ถ๊ฐํ๋ค.

```
$ wget -q -O - https://pkg.jenkins.io/debian/jenkins-ci.org.key | sudo apt-key add -
```

![image](https://user-images.githubusercontent.com/43662673/112255325-47fa2380-8ca5-11eb-81e7-30dd5d166364.png)

์ถ๊ฐ๊ฐ ๋๋ฉด OK ๋ฉ์ธ์ง๊ฐ ๋ฌ๋ค.

์ด๋ฒ์๋ repository๋ฅผ ์ถ๊ฐํ๋ค.

![image](https://user-images.githubusercontent.com/43662673/112255375-65c78880-8ca5-11eb-8dbe-befafeb6443d.png)

์ด์  apt-get ์๋ฐ์ดํธ ํ jenkins๋ฅผ ์ค์นํฉ๋๋ค.

```
$ sudo apt-get update
```

![image](https://user-images.githubusercontent.com/43662673/112255528-b9d26d00-8ca5-11eb-9b9c-cef5c199960d.png)

๊ทธ๋ฐ๋ฐ GPG error ๊ฐ ๋์ ์๋ฐ์ดํธ์ ์คํจ

```
W: GPG error: https://pkg.jenkins.io/debian-stable binary/ Release: The following signatures couldn't be verified because the public key is not available: NO_PUBKEY <16๊ฐ์ ๋๋ฌธ์ ์ํ๋ฒณ>
```

๊ทธ๋ด ๋๋ 

```
$ sudo apt-key adv --keyserver  keyserver.ubuntu.com --recv-keys <์๊น ๊ทธ 16๊ฐ ๋๋ฌธ์ ์ํ๋ฒณ>
```

๋ก ํด๊ฒฐํ  ์ ์๋ค.

![image](https://user-images.githubusercontent.com/43662673/112255604-e1293a00-8ca5-11eb-891c-2fdf919bedc5.png)



๋ค์ apt-get update๋ฅผ ํ์.

![image](https://user-images.githubusercontent.com/43662673/112255671-05851680-8ca6-11eb-9233-9049e0f266d3.png)

์ฑ๊ณต!

๊ทธ ๋ค์

```
$ sudo apt-get install jenkins
```

์ค์น๊ฐ ๋๋ฉด Jenkins ์คํํ๊ธฐ ์ ์ ํฌํธ๋ฅผ ๋ณ๊ฒฝํ๋ค.

ํฌํธ ๋ณ๊ฒฝ์ /etc/default/jenkins์์ ํ๋ค.

```
$ sudo vim /etc/default/jenkins 
```

ํ์ผ ์์์ HTTP_PORT๋ฅผ ์ฐพ์ 7070์ผ๋ก ๋ณ๊ฒฝํ๋ค.

```
# port for HTTP connector (default 8080; disable with -1)
HTTP_PORT=7070
```

systemctl์ ์ด์ฉํด jenkins๋ฅผ ์คํํ๋ค.

```
$ sudo systemctl start jenkins
```

systemctl์ ์๋ฌด๋ฐ ๋ฉ์์ง๊ฐ ๋์ค์ง ์์ต๋๋ค. ๊ทธ๋์ status๋ก ์ํ๋ฅผ ํ์ธํด ๋ด์ผ ํ๋ค.

```
$ sudo systemctl status jenkins
```

![image](https://user-images.githubusercontent.com/43662673/112257172-c5bf2e80-8ca7-11eb-9c61-464a7a105968.png)



์ด์  ๋ธ๋ผ์ฐ์ ๋ฅผ ์ด๊ณ  http://j4a401.p.ssafy.io:7070 ์ ๋ค์ด๊ฐ๋ค.

๋ง์ฝ ์๋์ ๊ฐ์ด ์  ํจ์ค ํ๋ฉด์ด ๋ณด์ด์ง ์๋๋ค๋ฉด

![image](https://user-images.githubusercontent.com/43662673/112257479-42eaa380-8ca8-11eb-94ba-a0d7a7bad7b5.png)

```
$ sudo systemctl stop jenkins
$ sudo systemctl start jenkins
```

์ค์งํ๋ค๊ฐ ๋ค์ ์์ํ๋ฉด ๋ณด์ธ๋ค.



/var/lib/jenkins/secrets/initialAdminPassword ์ด ๊ฒฝ๋ก์ ์๋ password๋ฅผ ํ์ธํด์ ์๋ ฅํ๋ผ๊ณ  ํ๋ ๋ญ๊ฐ ์จ์๋์ง ๋ณด๋ฌ ๊ฐ๋ค. (๋ณด์์ธ์ฆ๊ฐ์ ๊ฑฐ๋ผ๊ณ  ํ๋ค.)

![image](https://user-images.githubusercontent.com/43662673/112257761-aaa0ee80-8ca8-11eb-8bb7-52494639fe36.png)



์ถ์ฒํ๋ ํ๋ฌ๊ทธ์ธ ์ค์นํ๊ณ 

![image](https://user-images.githubusercontent.com/43662673/112257788-b7254700-8ca8-11eb-99ec-3e285c43790f.png)

ํ๋ฌ๊ทธ์ธ ์ค์น ์ค

![image](https://user-images.githubusercontent.com/43662673/112257831-c7d5bd00-8ca8-11eb-8964-6f6ade500372.png)

ํ๋ฌ๊ทธ์ธ ์ค์น ๋๋๊ณ  ์ ์  ์์ฑ ํ๋ฉด์ด๋ณด์ -> ์์ฃผ ์ฌ์ฉํ๋ ๊ณ์ ๊ณผ ๋น๋ฒ์ ์๋ ฅ

![image](https://user-images.githubusercontent.com/43662673/112258772-66165280-8caa-11eb-8a6f-dade321c27a9.png)

![image](https://user-images.githubusercontent.com/43662673/112258886-a1b11c80-8caa-11eb-92a5-7a586a0871bf.png)

๋์


### 2021-03-26

์ด์ ์ Jenkins๋ฅผ Gitlab์ ์ฐ๊ฒฐ๊น์ง ํ๊ณ  ๋จธ์งํ๋๋ฐ ๋ฐ์์ด ์๋ฐ..!

๋ถ๋ช build history์๋ ์ฐํ๊ณ 

![image](https://user-images.githubusercontent.com/43662673/112315380-6f74de80-8ced-11eb-8b19-2fff82455d3b.png)

๊ทผ๋ฐ ๋ฐ๋ ๊ฒ ์๋จ๋ค...

![image](https://user-images.githubusercontent.com/43662673/112315421-7a2f7380-8ced-11eb-8fb7-6d8eb00684a9.png)



์๊ณ ๋ณด๋.,, ํธ์ํ  ๋๋ง๋ค shell์ ์ํํ๋ ๊ฑธ ๋ฃ์ด์ผ ๋๋ค...!

![image](https://user-images.githubusercontent.com/43662673/112315034-0beab100-8ced-11eb-82f1-3a28ad0631fd.png)

![image](https://user-images.githubusercontent.com/43662673/112315227-45bbb780-8ced-11eb-96e0-b498695f8dc8.png)



๊ทผ๋ฐ ์ ๊ฑฐ ๋ฃ์ผ๋๊น ์ ์๊พธ ๋น๋ ์คํจํ๋๊ฑฐ์ง,,,?

Console Output์ ๋ณด๋๊น ๊ฒฝ๋ก๊ฐ home ๋๋ ํ ๋ฆฌ๊ฐ ์๋์๋ค..

![image](https://user-images.githubusercontent.com/43662673/112316476-7c460200-8cee-11eb-9094-0632b5ab85f8.png)



๊ฒฝ๋ก ๋ฐ๊ฟ์ฃผ๋๊น ๋ ์๋ฌ๊ฐ,,

![image-20210324221636303](C:\Users\0901B\AppData\Roaming\Typora\typora-user-images\image-20210324221636303.png)



### SSH Key ์์ฑํด์ ๋น๋ฐ๋ฒํธ ์์ด pullํ๊ธฐ

ubuntu์์ ๋น๋ฐ๋ฒํธ ์์ด pullํ  ์ ์๊ฒ ํ์

![image](https://user-images.githubusercontent.com/43662673/112318932-e8c20080-8cf0-11eb-96b3-84f8e2a604b5.png)

id_rsa.pub์ด ์์ผ๋ฉด ssh๊ฐ ์๋ ๊ฒ

https://goddaehee.tistory.com/254 ์ฌ๊ธฐ ์ฐธ๊ณ 



๊ทผ๋ฐ ๊ฒฐ๊ตญ https://webisfree.com/2017-05-19/git-%EC%95%84%EC%9D%B4%EB%94%94-%ED%8C%A8%EC%8A%A4%EC%9B%8C%EB%93%9C-%EC%9E%85%EB%A0%A5-%EC%95%88%ED%95%98%EB%8A%94-%EB%B0%A9%EB%B2%95 ์ด๊ฑธ๋ก ํด๊ฒฐ..

### 2021-03-27

1. GitLab์์ access Token ๋ฐ๊ธ๋ฐ๊ธฐ

   ์์ ๋ฉ๋ด์์ Settings๋ก ์ด๋

![image](https://user-images.githubusercontent.com/43662673/112259660-03be5180-8cac-11eb-8b01-e28372eec981.png)

2. ๊ถํ ์ค์  ํ Create Personal access token์ ๋๋ฅธ๋ค.

   ![image](https://user-images.githubusercontent.com/43662673/112259753-27819780-8cac-11eb-9821-475941c7d1e8.png)

3. ์์ฑ๋ ํ ํฐ ๋ณต์ฌ

   ![image-20210324142146668](C:\Users\0901B\AppData\Roaming\Typora\typora-user-images\image-20210324142146668.png)

4. Jenkins์์ GitLab ํ๋ฌ๊ทธ์ธ ์ค์น

   ![image](https://user-images.githubusercontent.com/43662673/112260212-dcb44f80-8cac-11eb-8e8c-ea15af94b1c7.png)

   ![image](https://user-images.githubusercontent.com/43662673/112260745-de324780-8cad-11eb-83e1-1c4f6212ff97.png)

๊ธฐ๋ฌ๊ธฐ๋ฌ,,

๋ชป์ฐธ์์ ๊ทธ๋ฅ ๋ ใใใใ

๋ญ ๊ป๋ค ํค๋๊น... Installed์ ์ ์๋ค. --> GitLab ๋ง๊ณ ,,, GitLab API๋ฅผ ์ค์นํ์

![image](https://user-images.githubusercontent.com/43662673/112263079-0d4ab800-8cb2-11eb-823b-cae41ab02d11.png)

![image](https://user-images.githubusercontent.com/43662673/112263196-408d4700-8cb2-11eb-8497-dc7d217f6b1e.png)

(global)์ ๋๋ฌ ๋ค์ด๊ฐ๋ค.

![image](https://user-images.githubusercontent.com/43662673/112263167-32d7c180-8cb2-11eb-8994-2d330befc968.png)

adding some credentials๋ฅผ ๋๋ฌ ๋ค์ด๊ฐ๋ค.

![image](https://user-images.githubusercontent.com/43662673/112263320-72061280-8cb2-11eb-8b6e-80671d7781dc.png)

์๊น ๋ฐ์ ํ ํฐ๋ ๋ฃ์ด์ฃผ๊ณ  OK

![image](https://user-images.githubusercontent.com/43662673/112263474-b5608100-8cb2-11eb-9623-771113cb7cf0.png)

new Item์ ๋๋ฌ์ค๋ค.

![image](https://user-images.githubusercontent.com/43662673/112275212-b4cfe680-8cc2-11eb-8394-61a584f4af5c.png)



---

๋ค์



![image-20210324211032561](C:\Users\0901B\AppData\Roaming\Typora\typora-user-images\image-20210324211032561.png)

![image](https://user-images.githubusercontent.com/43662673/112309886-418c9b80-8ce7-11eb-94a3-7172fadd2d8c.png)

์๊ฑด ์๋ฌ~

![image](https://user-images.githubusercontent.com/43662673/112309932-52d5a800-8ce7-11eb-9ce7-a7347fb9b0bc.png)

์๊ฑด ์ฑ๊ณต~

![image](https://user-images.githubusercontent.com/43662673/112310016-6bde5900-8ce7-11eb-9822-f39cd164effd.png)

jenkins์ GitLab์ ์ฐ๋ํ  User ์์ฑํด์ผ ํจ

![image](https://user-images.githubusercontent.com/43662673/112311006-8e24a680-8ce8-11eb-916e-409aa2aa47e5.png)

๋ฉ๋ด์์ New Item ๋๋ฌ์ฃผ๊ณ 

![image](https://user-images.githubusercontent.com/43662673/112310879-68979d00-8ce8-11eb-9378-914545bab4c3.png)

์ฌ๊ธฐ์ ํ๋์์ผ๋ก ์คํฌ๋ฉํ ๋ถ๋ถ์ด webhook url์ด๋ค.



๋ค์์ผ๋ก GitLab์์ webhook ๋ฑ๋กํด์ผ ํ๋ค.

![img](https://tech.osci.kr/assets/images/86039236/9.png)

1. ID/Password ๋ฐฉ์

![img](https://tech.osci.kr/assets/images/86039236/10.png)

2. Secret Token ๋ฐฉ์

   ๋ค์ build Trigger์ ๊ฐ์ ๊ณ ๊ธ ๋ฒํผ์ ๋๋ฌ์ฃผ๋ฉด

   ![image](https://user-images.githubusercontent.com/43662673/112311887-887b9080-8ce9-11eb-8035-0dc5f31103fb.png)

   ์์ ๊ฐ์ด ๋ฐ๊ธ ๋ฐ์ ์ ์๋ค.

   ![image](https://user-images.githubusercontent.com/43662673/112312207-e6a87380-8ce9-11eb-803a-fc9e4b8ca675.png)

   Test๋ก push events๋ฅผ ๋๋ฌ๋ณด๋ฉด

   ![image](https://user-images.githubusercontent.com/43662673/112312156-d98b8480-8ce9-11eb-9d47-671db187c972.png)

   ์์ ๊ฐ์ด ์ ์คํ๋๋ ๊ฒ์ ๋ณผ ์ ์๋ค.

์ฐ์ฐ

### 2021-03-28

PUN ์ฌ์ฉํ๊ธฐ 


### 2021-04-01
์นด๋ฉ๋ผ ์์  ๋ณํํ๊ธฐ