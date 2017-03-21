WORKSPACE=`pwd`
SOURCETABLEDIR=$WORKSPACE/../srcTable/ios/
PROJECTTABLEDIR=$WORKSPACE/../../UnityProject/Framework/Assets/Scripts/Game/Tables\

cd $WORKSPACE/xlsxconvert
TEMPOUTPUTDIR=$WORKSPACE/csharpoutput/
rm -rf $TEMPOUTPUTDIR
TARGET=csharp

python outputcode.py -i $SOURCETABLEDIR -o $TEMPOUTPUTDIR -t $TARGET

#cp -rf $TEMPOUTPUTDIR/Generate/* $PROJECTTABLEDIR
python copy_csharp_code.py $TEMPOUTPUTDIR/ $PROJECTTABLEDIR
cd -