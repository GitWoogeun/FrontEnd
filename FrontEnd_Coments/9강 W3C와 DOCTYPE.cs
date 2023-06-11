[ W3C와 DOCTYPE ]

사용하지 않을 태그에 대한 호환을 지정하기 위한 DOCTYPE

HTML DTD : Document Type Definition의 종류

렌더링 방식의 호환성 문제
다양한 브라우저의 경쟁 구도로 인한 독자적인 태그들
mozilla fire fox : <blink>
apple : <marquee/>
edge  : <object>

사용하지 않을 채그에 대한 호환성을 지정하기 위한 Document Type
[ HTML4 랜더링 방식( loose 쿼크방식) ]
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
            "http://www.w3.org/TR/html4/loose.dtd">
<!DOCTYPE html>
<html>
    <head>
        <title>HTML파일의 구조</title>
    </head>
    <body>

    </body>
</html>

[ HTML5부터는 통합 랜더링 방식 ]
<!DOCTYPE html>
<html>
    <head>
        <title>HTML파일의 구조</title>
    </head>
    <body>

    </body>
</html>
