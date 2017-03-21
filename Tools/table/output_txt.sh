WORKSPACE=`pwd`
SOURCETABLEDIR=$WORKSPACE/../srcTable/ios/
TABLERESDIR=$WORKSPACE/../../UnityProject/Framework/Assets/StreamingAssets/config/

cd $WORKSPACE/xlsxconvert
TEMPOUTPUTDIR=$WORKSPACE/tempoutput/
rm -rf $TEMPOUTPUTDIR
FORMAT=txt
python convertxlsx.py -i $SOURCETABLEDIR -o $TEMPOUTPUTDIR -f $FORMAT
cd -

cp -rf $TEMPOUTPUTDIR/client/ $TABLERESDIR