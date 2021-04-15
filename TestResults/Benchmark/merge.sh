#!/bin/bash

mergeFiles() {
  local _readme="$1"
  local _file="$2"

  echo ">> Updating $_readme with $_file"

  CONTENT="$(sed '/Benchmark/q' $_readme)
"
  CONTENT="$CONTENT
**Last update:** $(date -r $_file)

$(cat $_file)";
  echo "$CONTENT" > $_readme 
}

BASEPATH="../../"
for FILE in *.md;
do
  TMP_PATH="${FILE//[.]/\/}"
  REPORT_PATH="${TMP_PATH/\/md/\.md}"
  README_PATH="$BASEPATH$(dirname "$REPORT_PATH")"
  README="$README_PATH/README.md"

  if [ -f "$README" ];
  then
    if grep -q "^# Benchmark" $README;
    then
      mergeFiles "$README" "$FILE"
    else
      REPORT=$(basename "$REPORT_PATH")
      README_REPORT="README_${REPORT/-report-github.md/""}"
      README="$README_PATH/$README_REPORT.md"

      if [ -f "$README" ];
      then
        mergeFiles "$README" "$FILE"
      else
        echo "$README not found"
      fi
    fi
  else
    echo "$README not found"
  fi
done
