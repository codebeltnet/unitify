$version = minver -i -t v -v w
docker tag unitify-docfx:$version jcr.codebelt.net/geekle/unitify-docfx:$version
docker push jcr.codebelt.net/geekle/unitify-docfx:$version
